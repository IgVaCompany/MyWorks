/*
 * File: arduinorobot_linefollower_data.c
 *
 * Code generated for Simulink model 'arduinorobot_linefollower'.
 *
 * Model version                  : 1.124
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Mon Jul 16 11:29:23 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives: Unspecified
 * Validation result: Not run
 */

#include "arduinorobot_linefollower.h"
#include "arduinorobot_linefollower_private.h"

/* Block parameters (auto storage) */
P_arduinorobot_linefollower_T arduinorobot_linefollower_P = {
  7U,                                  /* Mask Parameter: DigitalOutput_pinNumber
                                        * Referenced by: '<S8>/Digital Output'
                                        */
  8U,                                  /* Mask Parameter: DigitalOutput_pinNumber_e
                                        * Referenced by: '<S9>/Digital Output'
                                        */
  11U,                                 /* Mask Parameter: DigitalOutput_pinNumber_g
                                        * Referenced by: '<S10>/Digital Output'
                                        */
  6U,                                  /* Mask Parameter: PWM_pinNumber
                                        * Referenced by: '<S14>/PWM'
                                        */
  5U,                                  /* Mask Parameter: PWM_pinNumber_m
                                        * Referenced by: '<S15>/PWM'
                                        */
  10U,                                 /* Mask Parameter: PWM_pinNumber_i
                                        * Referenced by: '<S16>/PWM'
                                        */
  9U,                                  /* Mask Parameter: PWM_pinNumber_f
                                        * Referenced by: '<S17>/PWM'
                                        */
  0,                                   /* Mask Parameter: DiscretePIDController_D
                                        * Referenced by: '<S1>/Derivative Gain'
                                        */
  15,                                  /* Mask Parameter: DiscretePIDController_I
                                        * Referenced by: '<S1>/Integral Gain'
                                        */
  35,                                  /* Mask Parameter: DiscretePIDController_P
                                        * Referenced by: '<S1>/Proportional Gain'
                                        */
  1U,                                  /* Mask Parameter: BitwiseOperator_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator'
                                        */
  2U,                                  /* Mask Parameter: BitwiseOperator1_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator1'
                                        */
  4U,                                  /* Mask Parameter: BitwiseOperator2_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator2'
                                        */
  2U,                                  /* Computed Parameter: AnalogInputMUX_IN_p1
                                        * Referenced by: '<S7>/Analog Input MUX_IN'
                                        */
  600,                                 /* Computed Parameter: IRsensorthreshold_Value
                                        * Referenced by: '<S5>/IR sensor threshold'
                                        */
  0,                                   /* Computed Parameter: Integrator_IC
                                        * Referenced by: '<S1>/Integrator'
                                        */
  100,                                 /* Computed Parameter: Basetorque_Value
                                        * Referenced by: '<S5>/Base torque'
                                        */
  0,                                   /* Computed Parameter: Constant_Value
                                        * Referenced by: '<S6>/Constant'
                                        */
  0,                                   /* Computed Parameter: Switch_Threshold
                                        * Referenced by: '<S6>/Switch'
                                        */
  0,                                   /* Computed Parameter: Constant1_Value
                                        * Referenced by: '<S6>/Constant1'
                                        */
  0,                                   /* Computed Parameter: Switch1_Threshold
                                        * Referenced by: '<S6>/Switch1'
                                        */
  1U,                                  /* Computed Parameter: UD_DelayLength
                                        * Referenced by: '<S3>/UD'
                                        */
  0,                                   /* Computed Parameter: UD_InitialCondition
                                        * Referenced by: '<S3>/UD'
                                        */
  16777,                               /* Computed Parameter: Integrator_gainval
                                        * Referenced by: '<S1>/Integrator'
                                        */
  5,                                   /* Computed Parameter: ForIterator_IterationLimit
                                        * Referenced by: '<S7>/For Iterator'
                                        */
  1,                                   /* Computed Parameter: Constant3_Value
                                        * Referenced by: '<S11>/Constant3'
                                        */
  0,                                   /* Computed Parameter: Desireddeviation_Value
                                        * Referenced by: '<Root>/Desired deviation'
                                        */
  5,                                   /* Computed Parameter: Constant_Value_a
                                        * Referenced by: '<S11>/Constant'
                                        */

  /*  Computed Parameter: Constant_Value_k
   * Referenced by: '<S4>/Constant'
   */
  { 0U, 1U, 2U, 3U, 4U },
  -128,                                /* Computed Parameter: IR3weight_Gain
                                        * Referenced by: '<S13>/IR3 weight'
                                        */
  64,                                  /* Computed Parameter: IR0weight_Gain
                                        * Referenced by: '<S13>/IR0 weight'
                                        */
  64,                                  /* Computed Parameter: IR1weight_Gain
                                        * Referenced by: '<S13>/IR1 weight'
                                        */
  -128,                                /* Computed Parameter: IR4weight_Gain
                                        * Referenced by: '<S13>/IR4 weight'
                                        */
  0                                    /* Computed Parameter: IR2weight_Gain
                                        * Referenced by: '<S13>/IR2 weight'
                                        */
};

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
