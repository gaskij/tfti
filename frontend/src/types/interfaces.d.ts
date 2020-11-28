export interface User {
  id: number;
  first_name: string;
  last_name: string;
  email: string;
  password: string;
  phone_number: string;
  user_summary: string;
}

export interface Friend {
  id_1: number; 
  id_2: number;
 }

export interface Blocked {
  user_id: number;
  blocked: number;
}

export interface Event {
  event_id: number; 
  host_id: number;
  location: string;
  event_date: Date;
  is_private: boolean;
  event_summary: string;
  addtional_links: string;
}

export interface EventAttendee {
  event_id: number;
  user_id: number;
}

export interface EventInvite {
  event_id: number; 
  event_invite_id: number;  
  accepted: boolean | null;
  recipient_id: number;
  sender_id: number;
  invite_time: Date;
}

export interface Item {
  event_id: number;
  item_id: number;  
  item_name: string;
  user_id: number;
  amount: number;
  unit_type: string;
}

export interface Message {
  messages_id : number; 
  sender_id: number;
  recipient_id: number;  
  message_time: Date;
  message: string;
}

export interface Media {
  media_id: number;
  event_id: number;
  user_id: number;
  file_path: string;
  media_description: string;
}
