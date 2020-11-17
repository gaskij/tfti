import React from 'react';
import { createStyles, makeStyles, Theme } from '@material-ui/core/styles';
import { Box, Paper } from '@material-ui/core';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    footerBox: {
      top: 'auto',
      bottom: 0,
      width: '100%',
    },
    footerPaper: {
      padding: theme.spacing(2),
      backgroundColor: theme.palette.primary.main,
      width: '100%',
    },
  }),
);

const Footer = () => {
  const classes = useStyles();

  return (
    <Box className={classes.footerBox} position="fixed" >
      <Paper className={classes.footerPaper} />
    </Box>
    
  );
}

export default Footer;
