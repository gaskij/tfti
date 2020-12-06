import React from 'react';
import { render } from '@testing-library/react';
import DashboardCard from './DashboardCard';

describe('Test <Dashboard /> component', () => {
  // A simple smoke test to check that the component renders with the minimal set of attributes
  test('should render the DashboardCard component without errors', () => {
    render(<DashboardCard title="test"/>);
  });

  // The given title attribute should show on the rendered panel.
  test('should display the correct title on the panel', () => {
    // Render the component and provide the 'getByText' function,
    // to find HTML elements by the text contained
    const { getByText } = render(<DashboardCard title="Test Title"/>);

    // An HTML element with the passed in title should be rendered in the DOM
    expect(getByText('Test Title')).toBeInTheDocument();
  });

  // // The DashboardCard component optionally accepts a 'style' attribute. It should apply that style 
  // // to the children of the card
  // test('should apply custom styling to the component', () => {
  //   const { getByText } = render(<DashboardCard title="test" style={{color: 'red'}}/>);
    
  //   // The title element should have the style properties passed when rendering the component
  //   expect(getByText('test')).toHaveStyle('color: red');
  // });

});