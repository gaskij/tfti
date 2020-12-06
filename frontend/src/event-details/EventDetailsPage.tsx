import * as React from 'react';
import { Box, Grid, Paper, Typography } from '@material-ui/core';

import { Event } from '../types/interfaces';
import {
  EventHeader,
  GuestList,
  ItemList
} from './panels';

const mockEvent: Event = {
  event_id: 4,
  host_id: 1,
  location: '100 Union Dr',
  event_date: new Date(),
  is_private: false,
  event_summary: "PAX East",
  addtional_links: 'a',
}

const EventDetailsPage = () => {

  return (
    <Box mx="auto" my={3}>
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
  )
}

export default EventDetailsPage;