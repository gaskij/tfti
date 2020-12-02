import React, { PropsWithChildren } from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { Box, Grid, Paper, Typography, IconButton } from '@material-ui/core';
import CreateOutlinedIcon from '@material-ui/icons/CreateOutlined';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    guest: {
      padding: theme.spacing(2),
      backgroundColor: theme.palette.grey[100],
      height: '90%',
      border: `6px solid #003f91`,
    },
    host: {
      padding: theme.spacing(2),
      backgroundColor: theme.palette.grey[100],
      height: '90%',
      border: `6px solid #e5f4e3`,
    },
    title: {
      textAlign: 'center',
      fontWeight: 500,
    },
    bolded: {
      fontWeight: 500,
      display: 'inline',
    },
    inline: {
      display: 'inline',
    },
    hidden: {
      display: 'none',
    },
  }),
);

interface Props {
  title: string;
  date: string;
  time: string;
  location: string;
  host: string;
  details: string;
  isHost: boolean;
  size?: boolean | "auto" | 2 | 1 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | undefined;
}
interface Props2 {
  type: string;
  content: string;
}

const EventCard = ({ title, date, time, location, host, details, size, isHost, children }: PropsWithChildren<Props>) => {
  const classes = useStyles();

  return (
    <Grid item xs={size || 5}>
      <Paper className={`${isHost ? classes.host : classes.guest}`} elevation={2}>
        <Box mb={1}>
          <Typography variant="h5" className={classes.title}>{title} 
            <IconButton aria-label="edit event" color="inherit">
              <CreateOutlinedIcon className={`${isHost ? '' : classes.hidden}`} />
            </IconButton>
          </Typography>
          
          <Grid
          container
          direction="row"
          justify="flex-start"
          flex-flow="wrap"
          alignContent="flex-start"
          >
            <EventData type='Date' content={date} />
            <EventData type='Time' content={time} />
            <EventData type='Location' content={location} />
            <EventData type='Host' content={host} />
          </Grid>
          <Typography variant="body1" className={classes.bolded}>Details:</Typography>
          <Typography variant="body1">{details}</Typography>
        </Box>
        {children}
      </Paper>
    </Grid>
  );
}
const EventData = ({ type, content, children }: PropsWithChildren<Props2>) => {
  const classes = useStyles();

  return (
    <Grid item xs={10}>
      <Typography variant="body1" className={classes.bolded}>{type}: </Typography>
      <Typography variant="body1" className={classes.inline}>{content}</Typography>
    </Grid>
  );
}
export default EventCard;
