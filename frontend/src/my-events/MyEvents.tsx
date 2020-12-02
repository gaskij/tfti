import React from 'react';
import { createStyles, makeStyles } from '@material-ui/core/styles';
import { Box, Grid, Typography, CircularProgress, } from '@material-ui/core';
import useAxios from 'axios-hooks';
import { Event } from '../types/interfaces';
import EventCard from './EventCard';

const useStyles = makeStyles(() =>
  createStyles({
    root: {
      flexGrow: 1,
    },
  }),
);

const mockEvents: Event[] = [
  {
    event_id: 1, 
    event_title: "TEST 1",
    host_id: 3,
    location: '1224 Rose Blv. Newtown RI',
    event_date: new Date(),
    is_private: true,
    event_summary: "It's halloweeeeeeeeeen babey. Time for the annual halloween bash at Ashley's house! Costume required ;)",
    addtional_links: 'a',
  },
  {
    event_id: 2, 
    event_title: "TEST 2",
    host_id: 4,
    location: "Brad's House",
    event_date: new Date(),
    is_private: true,
    event_summary: "BYOB",
    addtional_links: 'a',
  },
  {
    event_id: 3, 
    event_title: "TEST 3",
    host_id: 4,
    location: 'Prospect Park',
    event_date: new Date(),
    is_private: true,
    event_summary: "Llamapalooza",
    addtional_links: 'a',
  },
  {
    event_id: 4, 
    event_title: "TEST 4",
    host_id: 1,
    location: '100 Union Dr',
    event_date: new Date(),
    is_private: false,
    event_summary: "PAX East",
    addtional_links: 'a',
  },
  {
    event_id: 5, 
    event_title: "TEST 5",
    host_id: 2,
    location: 'The Void',
    event_date: new Date(),
    is_private: false,
    event_summary: "Tonight, we rise",
    addtional_links: 'a',
  },
]

const MyEvents = () => {
  const classes = useStyles();
  const [{ data, loading, error }] = useAxios<[Event]>({
    url: `/api/user/events/past`,
  }, { manual: false, useCache: false });

  return (
    loading 
      ? <CircularProgress color="secondary"/>
      : (
          !error
            ? <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
            : <Box mx={3} my={2} className={classes.root} display="flex" flexDirection="column">
                <Typography variant="h4">Upcoming Events</Typography>
                <Box mx="10%" my={3} display="flex" flex="1">
                  <Grid
                    container
                    className={classes.root}
                    spacing={2}
                    direction="row"
                    justify="center"
                    flex-flow="wrap"
                    alignItems="center"
                    alignContent="flex-start"
                  >
                    {mockEvents.map((event) => (
                      <EventCard e={event} />
                    ))}

                  </Grid>
                </Box>
              </Box>
      )
  );
}

export default MyEvents;
