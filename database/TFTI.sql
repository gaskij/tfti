CREATE TABLE "users" (
  "id" SERIAL PRIMARY KEY,
  "first_name" varchar,
  "last_name" varchar,
  "email" varchar,
  "pass_hash" varchar,
  "salt" varchar,
  "phone_number" varchar,
  "user_summary" varchar
);

CREATE TABLE "friends" (
  "id_1" int,
  "id_2" int
);

CREATE TABLE "blocked" (
  "user_id" int,
  "blocked_user_id" int
);

CREATE TABLE "events" (
  "event_id" SERIAL PRIMARY KEY,
  "event_name" varchar,
  "host_id" int,
  "location" varchar,
  "event_date" timestamp,
  "is_private" boolean,
  "event_summary" varchar,
  "addtional_links" varchar
);

CREATE TABLE "events_attendees" (
  "event_id" int,
  "user_id" int
);

CREATE TABLE "event_invites" (
  "event_id" int,
  "event_invite_id" SERIAL PRIMARY KEY,
  "accepted" boolean,
  "recipient_id" int,
  "sender_id" int,
  "invite_time" timestamp
);

CREATE TABLE "item_list" (
  "event_id" int,
  "item_id" SERIAL PRIMARY KEY,
  "item_name" varchar,
  "user_id" int,
  "amount" int,
  "unit_type" varchar
);

CREATE TABLE "messages" (
  "messages_id" SERIAL PRIMARY KEY,
  "sender_id" int,
  "recipient_id" int,
  "message_time" timestamp,
  "message" varchar
);

CREATE TABLE "media" (
  "media_id" SERIAL PRIMARY KEY,
  "event_id" int,
  "user_id" int,
  "file_path" varchar,
  "media_description" varchar
);

ALTER TABLE "events_attendees" ADD FOREIGN KEY ("event_id") REFERENCES "events" ("event_id");

ALTER TABLE "event_invites" ADD FOREIGN KEY ("event_id") REFERENCES "events" ("event_id");

ALTER TABLE "item_list" ADD FOREIGN KEY ("event_id") REFERENCES "events" ("event_id");

ALTER TABLE "media" ADD FOREIGN KEY ("event_id") REFERENCES "events" ("event_id");

ALTER TABLE "media" ADD FOREIGN KEY ("user_id") REFERENCES "users" ("id");
