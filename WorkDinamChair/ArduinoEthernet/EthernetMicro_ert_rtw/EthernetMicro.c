/*
 * File: EthernetMicro.c
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

#include "EthernetMicro.h"
#include "EthernetMicro_private.h"

/* Named constants for Chart: '<Root>/Chart' */
#define EthernetMicr_IN_NO_ACTIVE_CHILD ((uint8_T)0U)
#define EthernetMicro_IN_Off           ((uint8_T)1U)
#define EthernetMicro_IN_On            ((uint8_T)2U)

/* Block signals (auto storage) */
B_EthernetMicro_T EthernetMicro_B;

/* Block states (auto storage) */
DW_EthernetMicro_T EthernetMicro_DW;

/* Real-time model */
RT_MODEL_EthernetMicro_T EthernetMicro_M_;
RT_MODEL_EthernetMicro_T *const EthernetMicro_M = &EthernetMicro_M_;

/* Model step function */
void EthernetMicro_step(void)
{
  int32_T rtb_TCPIPReceive_o2;
  uint8_T tmp;

  /* S-Function (arduinotcpreceive_sfcn): '<Root>/TCP//IP Receive' */
  MW_TCPFinalread(EthernetMicro_P.TCPIPReceive_p1,
                  &EthernetMicro_B.TCPIPReceive_o1,
                  EthernetMicro_P.TCPIPReceive_p2, &rtb_TCPIPReceive_o2);

  /* Byte Unpacking: <Root>/Byte Unpacking  */
  (void)memcpy((uint8_T*)&EthernetMicro_B.ByteUnpacking, (uint8_T*)
               &EthernetMicro_B.TCPIPReceive_o1 + 0, 1);

  /* Chart: '<Root>/Chart' */
  /* Gateway: Chart */
  /* During: Chart */
  if (EthernetMicro_DW.is_active_c3_EthernetMicro == 0U) {
    /* Entry: Chart */
    EthernetMicro_DW.is_active_c3_EthernetMicro = 1U;

    /* Entry Internal: Chart */
    /* Transition: '<S1>:5' */
    EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_On;

    /* Entry 'On': '<S1>:1' */
    EthernetMicro_B.y = 1.0;
  } else if (EthernetMicro_DW.is_c3_EthernetMicro == EthernetMicro_IN_Off) {
    /* During 'Off': '<S1>:2' */
    if (EthernetMicro_B.ByteUnpacking > 5) {
      /* Transition: '<S1>:4' */
      EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_On;

      /* Entry 'On': '<S1>:1' */
      EthernetMicro_B.y = 1.0;
    }
  } else {
    /* During 'On': '<S1>:1' */
    if (EthernetMicro_B.ByteUnpacking <= 5) {
      /* Transition: '<S1>:3' */
      EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicro_IN_Off;

      /* Entry 'Off': '<S1>:2' */
      EthernetMicro_B.y = 0.0;
    }
  }

  /* End of Chart: '<Root>/Chart' */

  /* DataTypeConversion: '<S2>/Data Type Conversion' */
  if (EthernetMicro_B.y < 256.0) {
    if (EthernetMicro_B.y >= 0.0) {
      tmp = (uint8_T)EthernetMicro_B.y;
    } else {
      tmp = 0U;
    }
  } else {
    tmp = MAX_uint8_T;
  }

  /* End of DataTypeConversion: '<S2>/Data Type Conversion' */

  /* S-Function (arduinodigitaloutput_sfcn): '<S2>/Digital Output' */
  MW_digitalWrite(EthernetMicro_P.DigitalOutput_pinNumber, tmp);
}

/* Model initialize function */
void EthernetMicro_initialize(void)
{
  /* Registration code */

  /* initialize error status */
  rtmSetErrorStatus(EthernetMicro_M, (NULL));

  /* block I/O */
  (void) memset(((void *) &EthernetMicro_B), 0,
                sizeof(B_EthernetMicro_T));

  /* states (dwork) */
  (void) memset((void *)&EthernetMicro_DW, 0,
                sizeof(DW_EthernetMicro_T));

  /* Start for S-Function (arduinotcpreceive_sfcn): '<Root>/TCP//IP Receive' */
  MW_EthernetAndTCPServerBegin(EthernetMicro_P.TCPIPReceive_p1,
    EthernetMicro_P.TCPIPReceive_p2);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S2>/Digital Output' */
  MW_pinModeOutput(EthernetMicro_P.DigitalOutput_pinNumber);

  /* InitializeConditions for Chart: '<Root>/Chart' */
  EthernetMicro_DW.is_active_c3_EthernetMicro = 0U;
  EthernetMicro_DW.is_c3_EthernetMicro = EthernetMicr_IN_NO_ACTIVE_CHILD;
}

/* Model terminate function */
void EthernetMicro_terminate(void)
{
  /* (no terminate code required) */
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
