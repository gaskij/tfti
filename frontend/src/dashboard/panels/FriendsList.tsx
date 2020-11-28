import * as React from 'react';
import { createStyles, makeStyles } from '@material-ui/core/styles';
import useAxios from 'axios-hooks';
import {
  Avatar,
  Box,
  CircularProgress,
  Paper,
  Typography
} from '@material-ui/core';

import { User } from '../../types/interfaces';

// NOTES: No information about event in Invite

const mockFriends: User[] = [
  {
    id: 2,
    first_name: 'Aliza',
    last_name: 'Knight',
    email: '123@abc.com',
    password: 'uhhhhh',
    phone_number: '555-555-5555',
    user_summary: 'Summary',
  },
  {
    id: 3,
    first_name: 'Alexis',
    last_name: 'Joseph',
    email: '123@abc.com',
    password: 'uhhhhh',
    phone_number: '555-555-5555',
    user_summary: 'Summary',
  },
  {
    id: 4,
    first_name: 'Jacob',
    last_name: 'Xiang',
    email: '123@abc.com',
    password: 'uhhhhh',
    phone_number: '555-555-5555',
    user_summary: 'Summary',
  },
  {
    id: 5,
    first_name: 'Kris',
    last_name: 'Whelan',
    email: '123@abc.com',
    password: 'uhhhhh',
    phone_number: '555-555-5555',
    user_summary: 'Summary',
  }
]

const useStyles = makeStyles((theme) =>
  createStyles({
    avatar: {
      backgroundColor: theme.palette.primary.main,
      color: theme.palette.getContrastText(theme.palette.primary.main),
    },
  }),
);

const FriendsList = () => {
  const classes = useStyles();

    const [{ data, loading, error }] = useAxios<[User]>({
      url: `/api/user/id/friends`,
    }, { manual: false, useCache: false });

    return (
      loading 
        ? <CircularProgress color="secondary"/>
        : (
            !error
              ? <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
              : (
                <>
                  {mockFriends.map((friend) => (
                    <Paper style={{marginBottom: '16px'}} key={friend.id}>
                      <Box p={1}>
                        <Avatar alt={friend.first_name} src="/broken-image.jpg" className={classes.avatar} />
                        <Typography variant="body1">{friend.first_name} {friend.last_name}</Typography>
                      </Box>
                    </Paper>
                  ))}
                </>
              ) 
        )
    );
}

export default FriendsList;
