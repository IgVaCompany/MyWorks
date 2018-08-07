/*
 * File: arduinorobot_linefollower.h
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

#ifndef RTW_HEADER_arduinorobot_linefollower_h_
#define RTW_HEADER_arduinorobot_linefollower_h_
#include <stddef.h>
#include <string.h>
#ifndef arduinorobot_linefollower_COMMON_INCLUDES_
# define arduinorobot_linefollower_COMMON_INCLUDES_
#include "rtwtypes.h"
#include "rtw_continuous.h"
#include "rtw_solver.h"
#include "arduino_digitaloutput_lct.h"
#include "arduino_analoginput_lct.h"
#include "arduino_analogoutput_lct.h"
#endif                                 /* arduinorobot_linefollower_COMMON_INCLUDES_ */

#include "arduinorobot_linefollower_types.h"
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
  int16_T LeftTorque;                  /* '<S5>/Torque_estimation_to_control_Motors' */
  int16_T RightTorque;                 /* '<S5>/Torque_estimation_to_control_Motors' */
} B_arduinorobot_linefollower_T;

/* Block states (auto storage) for system '<Root>' */
typedef struct {
  int16_T Integrator_DSTATE;           /* '<S1>/Integrator' */
  int16_T UD_DSTATE;                   /* '<S3>/UD' */
  uint8_T is_active_c1_arduinorobot_linef;/* '<S5>/Torque_estimation_to_control_Motors' */
  uint8_T is_c1_arduinorobot_linefollower;/* '<S5>/Torque_estimation_to_control_Motors' */
} DW_arduinorobot_linefollower_T;

/* Parameters (auto storage) */
struct P_arduinorobot_linefollower_T_ {
  uint32_T DigitalOutput_pinNumber;    /* Mask Parameter: DigitalOutput_pinNumber
                                        * Referenced by: '<S8>/Digital Output'
                                        */
  uint32_T DigitalOutput_pinNumber_e;  /* Mask Parameter: DigitalOutput_pinNumber_e
                                        * Referenced by: '<S9>/Digital Output'
                                        */
  uint32_T DigitalOutput_pinNumber_g;  /* Mask Parameter: DigitalOutput_pinNumber_g
                                        * Referenced by: '<S10>/Digital Output'
                                        */
  uint32_T PWM_pinNumber;              /* Mask Parameter: PWM_pinNumber
                                        * Referenced by: '<S14>/PWM'
                                        */
  uint32_T PWM_pinNumber_m;            /* Mask Parameter: PWM_pinNumber_m
                                        * Referenced by: '<S15>/PWM'
                                        */
  uint32_T PWM_pinNumber_i;            /* Mask Parameter: PWM_pinNumber_i
                                        * Referenced by: '<S16>/PWM'
                                        */
  uint32_T PWM_pinNumber_f;            /* Mask Parameter: PWM_pinNumber_f
                                        * Referenced by: '<S17>/PWM'
                                        */
  int16_T DiscretePIDController_D;     /* Mask Parameter: DiscretePIDController_D
                                        * Referenced by: '<S1>/Derivative Gain'
                                        */
  int16_T DiscretePIDController_I;     /* Mask Parameter: DiscretePIDController_I
                                        * Referenced by: '<S1>/Integral Gain'
                                        */
  int16_T DiscretePIDController_P;     /* Mask Parameter: DiscretePIDController_P
                                        * Referenced by: '<S1>/Proportional Gain'
                                        */
  uint8_T BitwiseOperator_BitMask;     /* Mask Parameter: BitwiseOperator_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator'
                                        */
  uint8_T BitwiseOperator1_BitMask;    /* Mask Parameter: BitwiseOperator1_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator1'
                                        */
  uint8_T BitwiseOperator2_BitMask;    /* Mask Parameter: BitwiseOperator2_BitMask
                                        * Referenced by: '<S7>/Bitwise Operator2'
                                        */
  uint32_T AnalogInputMUX_IN_p1;       /* Computed Parameter: AnalogInputMUX_IN_p1
                                        * Referenced by: '<S7>/Analog Input MUX_IN'
                                        */
  int16_T IRsensorthreshold_Value;     /* Computed Parameter: IRsensorthreshold_Value
                                        * Referenced by: '<S5>/IR sensor threshold'
                                        */
  int16_T Integrator_IC;               /* Computed Parameter: Integrator_IC
                                        * Referenced by: '<S1>/Integrator'
                                        */
  int16_T Basetorque_Value;            /* Computed Parameter: Basetorque_Value
                                        * Referenced by: '<S5>/Base torque'
                                        */
  int16_T Constant_Value;              /* Computed Parameter: Constant_Value
                                        * Referenced by: '<S6>/Constant'
                                        */
  int16_T Switch_Threshold;            /* Computed Parameter: Switch_Threshold
                                        * Referenced by: '<S6>/Switch'
                                        */
  int16_T Constant1_Value;             /* Computed Parameter: Constant1_Value
                                        * Referenced by: '<S6>/Constant1'
                                        */
  int16_T Switch1_Threshold;           /* Computed Parameter: Switch1_Threshold
                                        * Referenced by: '<S6>/Switch1'
                                        */
  uint16_T UD_DelayLength;             /* Computed Parameter: UD_DelayLength
                                        * Referenced by: '<S3>/UD'
                                        */
  int16_T UD_InitialCondition;         /* Computed Parameter: UD_InitialCondition
                                        * Referenced by: '<S3>/UD'
                                        */
  int16_T Integrator_gainval;          /* Computed Parameter: Integrator_gainval
                                        * Referenced by: '<S1>/Integrator'
                                        */
  int8_T ForIterator_IterationLimit;   /* Computed Parameter: ForIterator_IterationLimit
                                        * Referenced by: '<S7>/For Iterator'
                                        */
  int8_T Constant3_Value;              /* Computed Parameter: Constant3_Value
                                        * Referenced by: '<S11>/Constant3'
                                        */
  int8_T Desireddeviation_Value;       /* Computed Parameter: Desireddeviation_Value
                                        * Referenced by: '<Root>/Desired deviation'
                                        */
  int8_T Constant_Value_a;             /* Computed Parameter: Constant_Value_a
                                        * Referenced by: '<S11>/Constant'
                                        */
  uint8_T Constant_Value_k[5];         /* Computed Parameter: Constant_Value_k
                                        * Referenced by: '<S4>/Constant'
                                        */
  int8_T IR3weight_Gain;               /* Computed Parameter: IR3weight_Gain
                                        * Referenced by: '<S13>/IR3 weight'
                                        */
  int8_T IR0weight_Gain;               /* Computed Parameter: IR0weight_Gain
                                        * Referenced by: '<S13>/IR0 weight'
                                        */
  int8_T IR1weight_Gain;               /* Computed Parameter: IR1weight_Gain
                                        * Referenced by: '<S13>/IR1 weight'
                                        */
  int8_T IR4weight_Gain;               /* Computed Parameter: IR4weight_Gain
                                        * Referenced by: '<S13>/IR4 weight'
                                        */
  int8_T IR2weight_Gain;               /* Computed Parameter: IR2weight_Gain
                                        * Referenced by: '<S13>/IR2 weight'
                                        */
};

/* Real-time Model Data Structure */
struct tag_RTM_arduinorobot_linefoll_T {
  const char_T *errorStatus;
};

/* Block parameters (auto storage) */
extern P_arduinorobot_linefollower_T arduinorobot_linefollower_P;

/* Block signals (auto storage) */
extern B_arduinorobot_linefollower_T arduinorobot_linefollower_B;

/* Block states (auto storage) */
extern DW_arduinorobot_linefollower_T arduinorobot_linefollower_DW;

/* Model entry point functions */
extern void arduinorobot_linefollower_initialize(void);
extern void arduinorobot_linefollower_step(void);
extern void arduinorobot_linefollower_terminate(void);

/* Real-time Model object */
extern RT_MODEL_arduinorobot_linefol_T *const arduinorobot_linefollower_M;

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
 * '<Root>' : 'arduinorobot_linefollower'
 * '<S1>'   : 'arduinorobot_linefollower/Discrete PID Controller'
 * '<S2>'   : 'arduinorobot_linefollower/Robot'
 * '<S3>'   : 'arduinorobot_linefollower/Discrete PID Controller/Differentiator'
 * '<S4>'   : 'arduinorobot_linefollower/Robot/IRsensors'
 * '<S5>'   : 'arduinorobot_linefollower/Robot/LineFollowerAlgorithm'
 * '<S6>'   : 'arduinorobot_linefollower/Robot/Motors'
 * '<S7>'   : 'arduinorobot_linefollower/Robot/IRsensors/For Iterator Subsystem'
 * '<S8>'   : 'arduinorobot_linefollower/Robot/IRsensors/For Iterator Subsystem/Digital Output MUXA'
 * '<S9>'   : 'arduinorobot_linefollower/Robot/IRsensors/For Iterator Subsystem/Digital Output MUXB'
 * '<S10>'  : 'arduinorobot_linefollower/Robot/IRsensors/For Iterator Subsystem/Digital Output MUXC'
 * '<S11>'  : 'arduinorobot_linefollower/Robot/LineFollowerAlgorithm/Current_deviation_calculation_from_IRsensors_reading'
 * '<S12>'  : 'arduinorobot_linefollower/Robot/LineFollowerAlgorithm/Torque_estimation_to_control_Motors'
 * '<S13>'  : 'arduinorobot_linefollower/Robot/LineFollowerAlgorithm/Current_deviation_calculation_from_IRsensors_reading/Weights'
 * '<S14>'  : 'arduinorobot_linefollower/Robot/Motors/IN_A1'
 * '<S15>'  : 'arduinorobot_linefollower/Robot/Motors/IN_A2'
 * '<S16>'  : 'arduinorobot_linefollower/Robot/Motors/IN_B1'
 * '<S17>'  : 'arduinorobot_linefollower/Robot/Motors/IN_B2'
 */
#endif                                 /* RTW_HEADER_arduinorobot_linefollower_h_ */

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
