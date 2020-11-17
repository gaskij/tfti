import React from 'react';
import { createStyles, makeStyles } from '@material-ui/core/styles';
import { Box, Grid, Typography } from '@material-ui/core';

import DashboardCard from './DashboardCard';

const useStyles = makeStyles(() =>
  createStyles({
    root: {
      flexGrow: 1,
    },
  }),
);

const Dashboard = () => {
  const classes = useStyles();

  return (
    <Box mx={3} my={2} className={classes.root} display="flex" flexDirection="column">
      <Typography variant="h6">Welcome, &lt;User&gt;!</Typography>
      <Box my={2} display="flex" flex="1">
        <Grid
          container
          className={classes.root}
          spacing={2}
          direction="row"
          justify="center"
          alignItems="stretch"
        >
          <DashboardCard size={4} title="Friend List" />
          <DashboardCard size={4} title="Upcoming Events" />
          <Grid
            container
            item
            xs={4}
            spacing={2}
            direction="row"
            justify="center"
            alignItems="stretch"
            // alignContent="stretch"
            // wrap="nowrap"
          >
            <DashboardCard title="Event Invites" />
            <DashboardCard title="Event History" />
          </Grid>
        </Grid>
      </Box>
    </Box>
  );
}

export default Dashboard;
