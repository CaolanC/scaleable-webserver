FROM node:18 AS frontend_source
WORKDIR /app 
COPY ./src/package.json ./src/package-lock.json ./ 
RUN npm install
COPY . .
RUN npm run build

FROM nginx:alpine AS frontend_server
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=frontend_source app/dist /usr/share/nginx/html/

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
