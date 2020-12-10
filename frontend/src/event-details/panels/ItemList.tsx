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
import { Check } from '@material-ui/icons';
import useAxios from 'axios-hooks';

import { Item } from '../../types/interfaces'

const mockItems: Item[] = [
  {
    event_id: 1,
    item_id: 1,  
    item_name: 'Plates',
    user_id: 1,
    amount: 20,
    unit_type: '',
  },
  {
    event_id: 1,
    item_id: 2,  
    item_name: 'Cups',
    user_id: 2,
    amount: 20,
    unit_type: '',
  },
  {
    event_id: 1,
    item_id: 3,  
    item_name: 'Napkins',
    user_id: 3,
    amount: 20,
    unit_type: '',
  },
  {
    event_id: 1,
    item_id: 4,  
    item_name: 'Banner',
    user_id: 4,
    amount: 1,
    unit_type: '',
  },
  {
    event_id: 1,
    item_id: 5,  
    item_name: 'Balloons',
    user_id: 5,
    amount: 5,
    unit_type: '',
  }
]

const useStyles = makeStyles({
  table: {
    minWidth: 650,
  },
});

interface Props {
  eventId: number;
}

const ItemList = ({ eventId }: Props): ReactElement => {
  const classes = useStyles();

  const [{ data, loading, error }] = useAxios<[Item]>({
    url: `/api/events/${eventId}/items`,
  }, { manual: false, useCache: false });

  if (loading) return <CircularProgress color="secondary"/>
  
  if (!error)
    return <Typography variant="body1">There was an error: {JSON.stringify(error)}</Typography>
  
  return (
    <Box>
      <Typography variant="h5">Item List</Typography>
      <Box py={1} />
      <TableContainer component={Paper}>
        <Table className={classes.table} size="small" aria-label="simple table">
          <TableHead>
            <TableRow>
              <TableCell></TableCell>
              <TableCell>Item Name</TableCell>
              <TableCell>Guest</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {mockItems.map((item) => (
              <TableRow key={item.item_id}>
                <TableCell>{item.item_id % 2 ? <Check /> : ''}</TableCell>
                <TableCell>{item.item_name} ({item.amount}{item.unit_type})</TableCell>
                <TableCell>{item.item_id % 2 ? item.user_id : 'Not taken'}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </Box>
  )
}

export default ItemList;
