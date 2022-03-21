import { render, screen } from '@testing-library/react';
import App from './App';

test('renders home screen', () => {
  render(<App />);
  const header = screen.getByText(/The shop/i);
  expect(header).toBeInTheDocument();
});
