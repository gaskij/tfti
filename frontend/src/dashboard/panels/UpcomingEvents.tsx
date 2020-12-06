import * as React from 'react';
import useAxios from 'axios-hooks';
import {
  Box,
  CircularProgress,
  Paper,
  Typography
} from '@material-ui/core';

import { Event } from '../../types/interfaces';
import { Link } from 'react-router-dom';

const mockEvents: Event[] = [
  {
    event_id: 1, 
    host_id: 1,
    location: '100 Union Dr',
    event_date: new Date(),
    is_private: false,
    event_summary: "Kathy's Baby Shower",
    addtional_links: 'a',
  },
  {
    event_id: 2, 
    host_id: 2,
    location: 'Prospect Park',
    event_date: new Date(),
    is_private: false,
    event_summary: "Fall Festival",
    addtional_links: 'a',
  },
  {
    event_id: 3, 
    host_id: 1,
    location: "Joe Mama's House",
    event_date: new Date(),
    is_private: false,
    event_summary: 'Absolute Banger',
    addtional_links: 'a',
  }
]

const UpcomingEvents = () => {
    const [{ data, loading, error }] = useAxios<[Event]>({
      url: `/api/invites`,
    }, { manual: false, useCache: false });

    return (
      loading 
        ? <CircularProgress color="secondary"/>
        : (
            !error
              ? <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
              : <>
                  {mockEvents.map((event) => (
                    <Link to={`/events/${event.event_id}`} key={event.event_id}>
                      <Paper elevation={2} style={{marginBottom: '16px'}}>
                        <Box p={1}>
                          <Typography variant="body1">{event.event_summary}</Typography>
                          <Typography variant="body1">{event.event_date.toLocaleDateString()}</Typography>
                          <Typography variant="body1">{event.location}</Typography>  
                        </Box>
                      </Paper>
                    </Link>
                  ))}
                </>
        )
    );
}

export default UpcomingEvents;
