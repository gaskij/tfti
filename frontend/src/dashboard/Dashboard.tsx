import React from 'react';
import { createStyles, makeStyles } from '@material-ui/core/styles';
import { Box, Grid, Typography } from '@material-ui/core';

import theme from '../theme';
import DashboardCard from './DashboardCard';
import {
  EventInvites,
} from './panels'

const useStyles = makeStyles((theme) =>
  createStyles({
    root: {
      flex: 1,
      marginTop: theme.spacing(2),
      marginBottom: theme.spacing(2),
    },
  }),
);

const Dashboard = () => {
  const classes = useStyles();

  return (
    <Box mx={3} my={2} className={classes.root} display="flex" flexDirection="column">
      <Typography variant="h6">Welcome, &lt;User&gt;!</Typography>
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
          <Grid item xs={4}>
            <Grid
              container
              direction="row"
              justify="center"
              alignItems="stretch"
              style={{height: '100%'}}
            >
              <DashboardCard style={{height: "98%", marginBottom: theme.spacing(1)}} title="Event Invites">
                <EventInvites />
              </DashboardCard>
              <DashboardCard style={{height: "98%", marginTop: theme.spacing(1)}} title="Event History" />
            </Grid>
          </Grid>
        </Grid>
    </Box>
  );
}

export default Dashboard;
