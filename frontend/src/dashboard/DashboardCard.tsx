import React, { PropsWithChildren } from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { Box, Grid, Paper, Typography } from '@material-ui/core';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    paper: {
      backgroundColor: theme.palette.grey[100],
      height: '100%',
    },
  }),
);

interface Props {
  title: string;
  style?: Object;
  size?: boolean | "auto" | 2 | 1 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | undefined;
}

const DashboardCard = ({ title, size, style, children }: PropsWithChildren<Props>) => {
  const classes = useStyles();

  return (
    <Grid item xs={size || 12} className="gridItem">
      <Paper className={classes.paper} elevation={8} style={style}>
        <Box p={2}>
          <Box mb={1}>
            <Typography variant="h6">{title}</Typography>
          </Box>
          {children}
        </Box>
      </Paper>
    </Grid>
  );
}

export default DashboardCard;
