--
-- PostgreSQL database dump
--

-- Dumped from database version 15.4
-- Dumped by pg_dump version 15.4

-- Started on 2023-09-08 19:19:15

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 215 (class 1259 OID 16415)
-- Name: Appointment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Appointment" (
    "ID" integer NOT NULL,
    "PatientID" bigint NOT NULL,
    "Date" date NOT NULL,
    "CancelReason" text,
    "CancelStatus" boolean DEFAULT false
);


ALTER TABLE public."Appointment" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16414)
-- Name: Appointment_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Appointment_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Appointment_ID_seq" OWNER TO postgres;

--
-- TOC entry 3336 (class 0 OID 0)
-- Dependencies: 214
-- Name: Appointment_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Appointment_ID_seq" OWNED BY public."Appointment"."ID";


--
-- TOC entry 217 (class 1259 OID 16424)
-- Name: Patient; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Patient" (
    "ID" integer NOT NULL,
    "Name" character varying NOT NULL
);


ALTER TABLE public."Patient" OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16423)
-- Name: Patient_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Patient_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Patient_ID_seq" OWNER TO postgres;

--
-- TOC entry 3337 (class 0 OID 0)
-- Dependencies: 216
-- Name: Patient_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Patient_ID_seq" OWNED BY public."Patient"."ID";


--
-- TOC entry 3178 (class 2604 OID 16418)
-- Name: Appointment ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Appointment" ALTER COLUMN "ID" SET DEFAULT nextval('public."Appointment_ID_seq"'::regclass);


--
-- TOC entry 3180 (class 2604 OID 16427)
-- Name: Patient ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Patient" ALTER COLUMN "ID" SET DEFAULT nextval('public."Patient_ID_seq"'::regclass);


--
-- TOC entry 3328 (class 0 OID 16415)
-- Dependencies: 215
-- Data for Name: Appointment; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Appointment" ("ID", "PatientID", "Date", "CancelReason", "CancelStatus") FROM stdin;
0	0	2023-09-08	\N	\N
2	0	2023-09-08	\N	f
1	0	-infinity	No show	t
\.


--
-- TOC entry 3330 (class 0 OID 16424)
-- Dependencies: 217
-- Data for Name: Patient; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Patient" ("ID", "Name") FROM stdin;
0	Zeeshan
1	Kamran
2	Mehmood
\.


--
-- TOC entry 3338 (class 0 OID 0)
-- Dependencies: 214
-- Name: Appointment_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Appointment_ID_seq"', 2, true);


--
-- TOC entry 3339 (class 0 OID 0)
-- Dependencies: 216
-- Name: Patient_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Patient_ID_seq"', 2, true);


--
-- TOC entry 3182 (class 2606 OID 16422)
-- Name: Appointment Appointment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Appointment"
    ADD CONSTRAINT "Appointment_pkey" PRIMARY KEY ("ID");


--
-- TOC entry 3184 (class 2606 OID 16431)
-- Name: Patient Patient_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Patient"
    ADD CONSTRAINT "Patient_pkey" PRIMARY KEY ("ID");


-- Completed on 2023-09-08 19:19:16

--
-- PostgreSQL database dump complete
--

