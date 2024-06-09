FROM node:18 AS frontend_source
WORKDIR /app 
COPY ./src/ /app/
# RUN npm run build

FROM nginx:alpine AS frontend_server
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=frontend_source /app/ /usr/share/nginx/html/

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
