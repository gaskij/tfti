import * as React from 'react';
import useAxios from 'axios-hooks';
import {
  Box,
  CircularProgress,
  Paper,
  Typography
} from '@material-ui/core';

import { Event } from '../../types/interfaces';

const mockEvents: Event[] = [
  {
    event_id: 4, 
    host_id: 1,
    location: '100 Union Dr',
    event_date: new Date(),
    is_private: false,
    event_summary: "PAX East",
    addtional_links: 'a',
  },
  {
    event_id: 5, 
    host_id: 2,
    location: 'Prospect Park',
    event_date: new Date(),
    is_private: false,
    event_summary: "Llamapalooza",
    addtional_links: 'a',
  },
]

const EventHistory = () => {
    const [{ data, loading, error }] = useAxios<[Event]>({
      url: `/api/user/events/past`,
    }, { manual: false, useCache: false });

    return (
      loading 
        ? <CircularProgress color="secondary"/>
        : (
            !error
              ? <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
              : <>
                  {mockEvents.map((event) => (
                    <Paper elevation={2} style={{marginBottom: '16px'}} key={event.event_id}>
                      <Box p={1}>
                        <Typography variant="body1">{event.event_summary}</Typography>
                      </Box>
                    </Paper>
                  ))}
                </>
        )
    );
}

export default EventHistory;
