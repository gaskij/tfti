import React from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { 
  AppBar,
  Toolbar,
} from '@material-ui/core';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    appBar: {
      top: 'auto',
      bottom: 0,
    },
  }),
);

const Header = () => {
  const classes = useStyles();

  return (
    <AppBar position="fixed" color="primary" className={classes.appBar}>
      <Toolbar variant="dense" />
    </AppBar>
  );
}

export default Header;
