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
  event_id: 1,
  event_title: "Kathy's Baby Shower",
  host_id: 1,
  location: '100 Union Dr',
  event_date: new Date(),
  is_private: false,
  event_summary: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam suscipit elit non elit malesuada vehicula. Quisque eget augue justo. Vivamus pharetra finibus blandit. Vivamus ut pellentesque nulla, eu varius elit. Aenean luctus ultricies neque sit amet feugiat. In aliquam a justo ac pretium. Aenean et diam consequat, ultricies nisi ut, laoreet diam. In feugiat nisl dictum ante rutrum, eget mollis lectus efficitur. Nulla facilisi. Mauris venenatis odio nulla, in tincidunt tortor elementum sit amet. Donec sed pharetra nibh. Mauris imperdiet interdum dui vel tincidunt.",
  addtional_links: 'a',
}

const EventDetailsPage = () => {
  const { id }: { id: string } = useParams();
  
  const [{ data, loading, error }] = useAxios<Event>({
    url: `${baseURL}/events/${id}`,
  }, { manual: false, useCache: false });

  if (loading) return <CircularProgress color="secondary"/>
  
  if (!error) return <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>

  return (
    <Box mx="auto" my={2}>
      <Box mx={3} style={{maxWidth: '1400px'}}>
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
              <GuestList hostId={1} guestList={data?.guests ? data.guests : [{}]} />
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