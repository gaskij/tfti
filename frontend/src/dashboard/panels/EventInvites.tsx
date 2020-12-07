import * as React from 'react';
import useAxios from 'axios-hooks';
import {
  Box,
  CircularProgress,
  Paper,
  Typography
} from '@material-ui/core';

import { EventInvite } from '../../types/interfaces';

// NOTES: No information about event in Invite

const mockInvites: EventInvite[] = [
  {
    event_id: 1, 
    event_invite_id: 1,  
    accepted: null,
    recipient_id: 2,
    sender_id: 1,
    invite_time: new Date()
  }
]

const EventInvites = () => {
    const [{ data, loading, error }] = useAxios<[EventInvite]>({
      url: `/api/invites`,
    }, { manual: false, useCache: false });

    return (
      loading 
        ? <CircularProgress color="secondary"/>
        : (
            !error
              ? <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
              : <>
                  {mockInvites.map((invite) => (
                    <Paper elevation={2} key={invite.event_invite_id}>
                      <Box p={1}>
                        <Typography variant="body1">Invite ID: {invite.event_invite_id}</Typography>
                        <Typography variant="body1">Sender ID: {invite.sender_id}</Typography>
                        <Typography variant="body1">Event ID: {invite.event_id}</Typography>  
                      </Box>
                    </Paper>
                  ))}
                </>
        )
    );
}

export default EventInvites;
