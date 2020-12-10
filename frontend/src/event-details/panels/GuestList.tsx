import * as React from 'react';
import { ReactElement } from 'react';
import {
  Box,
  CircularProgress,
  makeStyles,
  Paper,
  Table,
  TableContainer,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Typography,
} from '@material-ui/core';
import { Check, Clear } from '@material-ui/icons';
import useAxios from 'axios-hooks';

import { User } from '../../types/interfaces'

const mockGuests: User[] = [
  {
    id: 1,
    first_name: 'Justin',
    last_name: 'Gaskins',
    email: '123@abc.com',
    password: 'uhhhhh',
    phone_number: '555-555-5555',
    user_summary: 'Summary',
  },
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
    last_name: 'Jiang',
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

const useStyles = makeStyles({
  table: {
    minWidth: 650,
  },
});

interface Props {
  hostId: number;
  guestList: Object[];
}

const GuestList = ({ hostId, guestList }: Props): ReactElement => {
  const classes = useStyles();

  // const [{ data, loading, error }] = useAxios<[User]>({
  //   url: `/api/events/id/guests`,
  // }, { manual: false, useCache: false });

  // if (loading) return <CircularProgress color="secondary"/>
  
  // if (!error)
  //   return <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
  
  return (
    <Box>
      <Typography variant="h5">Guest List</Typography>
      <Box py={1} />
      <TableContainer component={Paper}>
        <Table className={classes.table} size="small" aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell>Accepted?</TableCell>
              <TableCell>
                {mockGuests.filter(guest => guest.id === hostId)[0].first_name} (Host)
              </TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {mockGuests.filter(guest => guest.id !== hostId).map((guest) => (
              <TableRow key={guest.id}>
                <TableCell>{guest.id < 3 ? <Check /> : <Clear />}</TableCell>
                <TableCell>{guest.first_name} {guest.last_name}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </Box>
  )
}

export default GuestList;
