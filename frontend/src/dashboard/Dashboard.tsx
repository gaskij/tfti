import React from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { Box, Grid, Paper } from '@material-ui/core';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      flexGrow: 1,
    },
    paper: {
      padding: theme.spacing(2),
      textAlign: 'center',
      color: theme.palette.text.secondary,
    },
  }),
);

const Header = () => {
  const classes = useStyles();

  return (
    <Box m={2}>
      <Grid
        container
        className={classes.root}
        spacing={2}
        direction="row"
        justify="center"
        alignItems="stretch"
      >
        <Grid item>
          <Paper className={classes.paper}>xs=12</Paper>
        </Grid>
        <Grid item>
          <Paper className={classes.paper}>xs=12 sm=6</Paper>
        </Grid>
        <Grid
          item
          direction="column"
          justify="center"
          alignItems="center"
        >
          <Grid item>
            <Paper className={classes.paper}>xs=12 sm=6</Paper>
          </Grid>
          <Grid item>
            <Paper className={classes.paper}>xs=12 sm=6</Paper>
          </Grid>
        </Grid>
      </Grid>
    </Box>
  );
}

export default Header;
