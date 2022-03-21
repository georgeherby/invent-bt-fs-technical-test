import { Router } from 'express';


// Export the base-router
const baseRouter = Router();

// Setup routers
baseRouter.get('/ping', (request, response) => {
    response.send('pong');
});

// Export default.
export default baseRouter;
