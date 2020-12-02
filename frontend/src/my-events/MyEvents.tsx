import React from 'react';
import { createStyles, makeStyles } from '@material-ui/core/styles';
import { Box, Grid, Typography } from '@material-ui/core';

import EventCard from './EventCard';

const useStyles = makeStyles(() =>
  createStyles({
    root: {
      flexGrow: 1,
    },
  }),
);

const MyEvents = () => {
  const classes = useStyles();

  return (
    <Box mx={3} my={2} className={classes.root} display="flex" flexDirection="column">
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
          <EventCard isHost={true} title="TEST1" date="October 31st, 1990" time="7:00 PM" location="Ashley's House" host="Ashley" details="heya ashley here this is the link for this years halloweeeeeeeen party hell yeah" />

          <EventCard isHost={false} title="TEST2" date="December 31st, 1990" time="7:00 PM" location="Brad's House" host="Brad" details="BYOB" />

          <EventCard isHost={false} title="TEST2" date="December 31st, 1990" time="7:00 PM" location="2034 Maple Street, Newtown NJ" host="Brad" details="BYOB" />

          <EventCard isHost={false} title="TEST3" date="December 31st, 1990" time="7:00 PM" location="Brad's House" host="Brad" details="BYOB" />

          <EventCard isHost={false} title="TEST4" date="December 31st, 1990" time="7:00 PM" location="Brad's House" host="Brad" details="BYOB" />

        </Grid>
      </Box>
    </Box>
  );
}

export default MyEvents;
