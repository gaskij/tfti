import React from 'react';
import { render } from '@testing-library/react';
import Dashboard from './Dashboard';

describe('Test <Dashboard /> component', () => {
  test('should render the Dashboard without errors', () => {
    render(<Dashboard />);
  });

  test('should display a welcome message to the logged in user', () => {
    const { getByText } = render(<Dashboard />);
    expect(getByText('Welcome, <User>!')).toBeInTheDocument();
  });

  test('should contain four panels: Friends, Upcoming, Invites, History', () => {
    const { getByText } = render(<Dashboard />);
    expect(getByText('Friends List')).toBeInTheDocument();
    expect(getByText('Upcoming Events')).toBeInTheDocument();
    expect(getByText('Event Invites')).toBeInTheDocument();
    expect(getByText('Event History')).toBeInTheDocument();
  });

});

