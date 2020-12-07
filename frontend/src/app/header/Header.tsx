import React, { useState } from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { AccountCircle, Mail } from '@material-ui/icons';
import { 
  AppBar,
  Toolbar,
  Typography,
  IconButton,
  Menu,
  MenuItem,
  Button,
  Badge,
  Box
} from '@material-ui/core';
import { Link, NavLink } from "react-router-dom";

import logo from './logo.svg';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      flexGrow: 1,
    },
    title: {
      flexGrow: 1,
    },
  }),
);

const Header = () => {
  const classes = useStyles();
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const open = Boolean(anchorEl);

  const auth = true;

  const handleMenu = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  return (
    <div className={classes.root}>
      <AppBar position="static">
        <Toolbar>
          <Link to="/">
            <Box>
              <img
                src={logo}
                alt="tfti"
                width="30"
                height="30"
                style={{display: 'inline-block', verticalAlign: '-35%'}}
              />
              <Typography style={{display: 'inline-block', paddingLeft: '4px'}} variant="h6">tfti</Typography>
            </Box>
          </Link>
          <span className={classes.title} />
          <div>
            <Button color="inherit">Browse</Button>
            <Button color="inherit">Create Event</Button>
            <NavLink to="/my-events" activeClassName="currentPage">
              <Button color="inherit">My Events</Button>
            </NavLink>
          </div>
          {auth && (
            <div>
              <IconButton aria-label="show 3 new invites" color="inherit">
                <Badge badgeContent={3} color="secondary">
                  <Mail />
                </Badge>
              </IconButton>
              <IconButton
                aria-label="account of current user"
                aria-controls="menu-appbar"
                aria-haspopup="true"
                onClick={handleMenu}
                color="inherit"
              >
                <AccountCircle />
              </IconButton>
              <Menu
                id="menu-appbar"
                anchorEl={anchorEl}
                anchorOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                keepMounted
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'right',
                }}
                open={open}
                onClose={handleClose}
              >
                <MenuItem onClick={handleClose}>Profile</MenuItem>
                <MenuItem onClick={handleClose}>My Account</MenuItem>
              </Menu>
            </div>
          )}
        </Toolbar>
      </AppBar>
    </div>
  );
}

export default Header;
