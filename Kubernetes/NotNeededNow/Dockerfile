FROM python:3.11-slim

WORKDIR /app
ENV PIP_NO_CACHE_DIR=1

# install build tools only if you need to compile deps; remove if not needed
RUN apt-get update && apt-get install -y --no-install-recommends build-essential \
  && rm -rf /var/lib/apt/lists/*

# install deps first for better layer caching
COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

# copy source
COPY . .

# app must expose a WSGI callable named "app" in app.py (adjust if different)
ENV PORT=8080
EXPOSE 8080
CMD ["gunicorn", "-b", "0.0.0.0:8080", "app:app"]
