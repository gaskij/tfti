import * as React from 'react';
import { Box, CircularProgress, Grid, Paper, Typography } from '@material-ui/core';
import useAxios from 'axios-hooks';
import { useParams } from 'react-router-dom';

import { Event } from '../types/interfaces';
import {
  EventHeader,
  GuestList,
  ItemList
} from './panels';
import { baseURL } from '../config';

const mockEvent: Event = {
  event_id: 4,
  event_title: "PAX East",
  host_id: 1,
  location: '100 Union Dr',
  event_date: new Date(),
  is_private: false,
  event_summary: "PAX East",
  addtional_links: 'a',
}

const EventDetailsPage = () => {
  const { id }: { id: string } = useParams();
  
  const [{ data, loading, error }] = useAxios<[Event]>({
    url: `${baseURL}/events/${id}`,
  }, { manual: false, useCache: false });

  if (loading) return <CircularProgress color="secondary"/>
  
  if (!error) return <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>

  return (
    <Box mx="auto" my={2}>
      <Box mx={3}>
        <Grid
          container
          direction="column"
          spacing={3}
        >
          <Grid item>
            <EventHeader event={mockEvent} />
          </Grid>
          <Grid item>
            <Paper variant="outlined">
              <Box p={1}>
                <Typography variant="body1">{mockEvent.event_summary}</Typography>
              </Box>
            </Paper>
          </Grid>
          <Grid item container
            direction="row"
            justify="center"
            alignItems="stretch"
            spacing={3}
          >
            <Grid item>
              <GuestList hostId={1} />
            </Grid>
            <Grid item>
              <ItemList eventId={1} />
            </Grid>
          </Grid>
        </Grid>
      </Box>
    </Box>
  )
}

export default EventDetailsPage;