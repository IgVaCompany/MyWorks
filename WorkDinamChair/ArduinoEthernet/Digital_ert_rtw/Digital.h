/*
 * File: Digital.h
 *
 * Code generated for Simulink model 'Digital'.
 *
 * Model version                  : 1.1
 * Simulink Coder version         : 8.9 (R2015b) 13-Aug-2015
 * C/C++ source code generated on : Mon Jul 16 11:06:31 2018
 *
 * Target selection: ert.tlc
 * Embedded hardware selection: Atmel->AVR
 * Code generation objectives:
 *    1. Execution efficiency
 *    2. RAM efficiency
 * Validation result: Not run
 */

#ifndef RTW_HEADER_Digital_h_
#define RTW_HEADER_Digital_h_
#include <stddef.h>
#ifndef Digital_COMMON_INCLUDES_
# define Digital_COMMON_INCLUDES_
#include "rtwtypes.h"
#include "arduino_digitaloutput_lct.h"
#endif                                 /* Digital_COMMON_INCLUDES_ */

#include "MW_target_hardware_resources.h"

/* Macros for accessing real-time model data structure */
#ifndef rtmGetErrorStatus
# define rtmGetErrorStatus(rtm)        ((rtm)->errorStatus)
#endif

#ifndef rtmSetErrorStatus
# define rtmSetErrorStatus(rtm, val)   ((rtm)->errorStatus = (val))
#endif

#define Digital_M                      (rtM)

/* Forward declaration for rtModel */
typedef struct tag_RTM RT_MODEL;

/* External inputs (root inport signals with auto storage) */
typedef struct {
  real_T In1;                          /* '<Root>/In1' */
} ExtU;

/* Real-time Model Data Structure */
struct tag_RTM {
  const char_T *errorStatus;
};

/* External inputs (root inport signals with auto storage) */
extern ExtU rtU;

/* Model entry point functions */
extern void Digital_initialize(void);
extern void Digital_step(void);

/* Real-time Model object */
extern RT_MODEL *const rtM;

/*-
 * The generated code includes comments that allow you to trace directly
 * back to the appropriate location in the model.  The basic format
 * is <system>/block_name, where system is the system number (uniquely
 * assigned by Simulink) and block_name is the name of the block.
 *
 * Note that this particular code originates from a subsystem build,
 * and has its own system numbers different from the parent model.
 * Refer to the system hierarchy for this subsystem below, and use the
 * MATLAB hilite_system command to trace the generated code back
 * to the parent model.  For example,
 *
 * hilite_system('Test/Digital Output')    - opens subsystem Test/Digital Output
 * hilite_system('Test/Digital Output/Kp') - opens and selects block Kp
 *
 * Here is the system hierarchy for this model
 *
 * '<Root>' : 'Test'
 * '<S1>'   : 'Test/Digital Output'
 */
#endif                                 /* RTW_HEADER_Digital_h_ */

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
