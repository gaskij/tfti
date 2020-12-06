import * as React from 'react';
import { ReactElement } from 'react';
import { Grid, Typography } from '@material-ui/core';
import { Edit } from '@material-ui/icons';

import { Event } from '../../types/interfaces'

interface Props {
  event: Event;
}

const EventHeader = ({ event }: Props): ReactElement => (
  <Grid
    container
    direction="row"
    justify="flex-start"
    alignItems="flex-end"
    spacing={2}
  >
    <Grid item>
      <Typography variant="h3">{event.event_id} Name</Typography>
    </Grid>
    <Grid item style={{flex: 1}}>
      <Typography variant="body1">
        {event.event_date.toDateString()} @ {event.event_date.toLocaleTimeString()}
      </Typography>
      <Typography variant="body1">
        at {event.location}
      </Typography>
    </Grid>
    <Grid item>
      <Edit />
    </Grid>
  </Grid>
)

export default EventHeader;
