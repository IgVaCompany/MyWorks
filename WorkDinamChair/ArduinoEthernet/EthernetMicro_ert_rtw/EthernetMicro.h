/*
 * File: EthernetMicro.h
 *
 * Code generated for Simulink model 'EthernetMicro'.
 *
 * Model version                  : 1.9
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Wed Aug 08 09:39:26 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives: Unspecified
 * Validation result: Not run
 */

#ifndef RTW_HEADER_EthernetMicro_h_
#define RTW_HEADER_EthernetMicro_h_
#include <stddef.h>
#include <string.h>
#ifndef EthernetMicro_COMMON_INCLUDES_
# define EthernetMicro_COMMON_INCLUDES_
#include "rtwtypes.h"
#include "rtw_continuous.h"
#include "rtw_solver.h"
#include "arduino_tcpreceive_lct.h"
#include "arduino_digitaloutput_lct.h"
#endif                                 /* EthernetMicro_COMMON_INCLUDES_ */

#include "EthernetMicro_types.h"
#include "MW_target_hardware_resources.h"

/* Macros for accessing real-time model data structure */
#ifndef rtmGetErrorStatus
# define rtmGetErrorStatus(rtm)        ((rtm)->errorStatus)
#endif

#ifndef rtmSetErrorStatus
# define rtmSetErrorStatus(rtm, val)   ((rtm)->errorStatus = (val))
#endif

/* Block signals (auto storage) */
typedef struct {
  real_T y;                            /* '<Root>/Chart' */
  uint8_T TCPIPReceive_o1;             /* '<Root>/TCP//IP Receive' */
  uint8_T ByteUnpacking;               /* '<Root>/Byte Unpacking ' */
} B_EthernetMicro_T;

/* Block states (auto storage) for system '<Root>' */
typedef struct {
  int_T ByteUnpacking_IWORK[2];        /* '<Root>/Byte Unpacking ' */
  uint8_T is_active_c3_EthernetMicro;  /* '<Root>/Chart' */
  uint8_T is_c3_EthernetMicro;         /* '<Root>/Chart' */
} DW_EthernetMicro_T;

/* Parameters (auto storage) */
struct P_EthernetMicro_T_ {
  uint32_T DigitalOutput_pinNumber;    /* Mask Parameter: DigitalOutput_pinNumber
                                        * Referenced by: '<S2>/Digital Output'
                                        */
  uint32_T TCPIPReceive_p2;            /* Computed Parameter: TCPIPReceive_p2
                                        * Referenced by: '<Root>/TCP//IP Receive'
                                        */
  uint8_T TCPIPReceive_p1;             /* Computed Parameter: TCPIPReceive_p1
                                        * Referenced by: '<Root>/TCP//IP Receive'
                                        */
};

/* Real-time Model Data Structure */
struct tag_RTM_EthernetMicro_T {
  const char_T *errorStatus;
};

/* Block parameters (auto storage) */
extern P_EthernetMicro_T EthernetMicro_P;

/* Block signals (auto storage) */
extern B_EthernetMicro_T EthernetMicro_B;

/* Block states (auto storage) */
extern DW_EthernetMicro_T EthernetMicro_DW;

/* Model entry point functions */
extern void EthernetMicro_initialize(void);
extern void EthernetMicro_step(void);
extern void EthernetMicro_terminate(void);

/* Real-time Model object */
extern RT_MODEL_EthernetMicro_T *const EthernetMicro_M;

/*-
 * The generated code includes comments that allow you to trace directly
 * back to the appropriate location in the model.  The basic format
 * is <system>/block_name, where system is the system number (uniquely
 * assigned by Simulink) and block_name is the name of the block.
 *
 * Use the MATLAB hilite_system command to trace the generated code back
 * to the model.  For example,
 *
 * hilite_system('<S3>')    - opens system 3
 * hilite_system('<S3>/Kp') - opens and selects block Kp which resides in S3
 *
 * Here is the system hierarchy for this model
 *
 * '<Root>' : 'EthernetMicro'
 * '<S1>'   : 'EthernetMicro/Chart'
 * '<S2>'   : 'EthernetMicro/Digital Output'
 */
#endif                                 /* RTW_HEADER_EthernetMicro_h_ */

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
