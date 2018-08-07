/*
 * File: arduinorobot_linefollower.c
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

/* Named constants for Chart: '<S5>/Torque_estimation_to_control_Motors' */
#define arduinorobot_IN_NO_ACTIVE_CHILD ((uint8_T)0U)
#define arduinorobot_line_IN_GoStraight ((uint8_T)1U)
#define arduinorobot_linef_IN_TurnRight ((uint8_T)3U)
#define arduinorobot_linefo_IN_TurnLeft ((uint8_T)2U)

/* Block signals (auto storage) */
B_arduinorobot_linefollower_T arduinorobot_linefollower_B;

/* Block states (auto storage) */
DW_arduinorobot_linefollower_T arduinorobot_linefollower_DW;

/* Real-time model */
RT_MODEL_arduinorobot_linefol_T arduinorobot_linefollower_M_;
RT_MODEL_arduinorobot_linefol_T *const arduinorobot_linefollower_M =
  &arduinorobot_linefollower_M_;
int16_T div_s16_floor(int16_T numerator, int16_T denominator)
{
  int16_T quotient;
  uint16_T absNumerator;
  uint16_T absDenominator;
  uint16_T tempAbsQuotient;
  boolean_T quotientNeedsNegation;
  if (denominator == 0) {
    quotient = numerator >= 0 ? MAX_int16_T : MIN_int16_T;

    /* Divide by zero handler */
  } else {
    absNumerator = (uint16_T)(numerator >= 0 ? numerator : -numerator);
    absDenominator = (uint16_T)(denominator >= 0 ? denominator : -denominator);
    quotientNeedsNegation = ((numerator < 0) != (denominator < 0));
    tempAbsQuotient = absNumerator / absDenominator;
    if (quotientNeedsNegation) {
      absNumerator %= absDenominator;
      if (absNumerator > 0U) {
        tempAbsQuotient++;
      }
    }

    quotient = quotientNeedsNegation ? -(int16_T)tempAbsQuotient : (int16_T)
      tempAbsQuotient;
  }

  return quotient;
}

/* Model step function */
void arduinorobot_linefollower_step(void)
{
  uint16_T rtb_AnalogInputMUX_IN_0;
  int8_T s7_iter;
  int16_T rtb_Assignment[5];
  boolean_T rtb_RelationalOperator;
  boolean_T rtb_RelationalOperator1;
  boolean_T rtb_RelationalOperator2;
  boolean_T rtb_RelationalOperator3;
  boolean_T rtb_RelationalOperator4;
  int16_T rtb_Diff;
  int16_T rtb_TSamp;
  int16_T rtb_Switch1_idx_1;
  int32_T tmp;

  /* Outputs for Iterator SubSystem: '<S4>/For Iterator Subsystem' incorporates:
   *  ForIterator: '<S7>/For Iterator'
   */
  for (s7_iter = 0; s7_iter <
       arduinorobot_linefollower_P.ForIterator_IterationLimit; s7_iter++) {
    /* S-Function (arduinodigitaloutput_sfcn): '<S8>/Digital Output' incorporates:
     *  Constant: '<S4>/Constant'
     *  S-Function (sfix_bitop): '<S7>/Bitwise Operator'
     *  Selector: '<S7>/Selector'
     */
    MW_digitalWrite(arduinorobot_linefollower_P.DigitalOutput_pinNumber,
                    arduinorobot_linefollower_P.Constant_Value_k[s7_iter] &
                    arduinorobot_linefollower_P.BitwiseOperator_BitMask);

    /* S-Function (arduinodigitaloutput_sfcn): '<S9>/Digital Output' incorporates:
     *  Constant: '<S4>/Constant'
     *  S-Function (sfix_bitop): '<S7>/Bitwise Operator1'
     *  Selector: '<S7>/Selector'
     */
    MW_digitalWrite(arduinorobot_linefollower_P.DigitalOutput_pinNumber_e,
                    arduinorobot_linefollower_P.Constant_Value_k[s7_iter] &
                    arduinorobot_linefollower_P.BitwiseOperator1_BitMask);

    /* S-Function (arduinodigitaloutput_sfcn): '<S10>/Digital Output' incorporates:
     *  Constant: '<S4>/Constant'
     *  S-Function (sfix_bitop): '<S7>/Bitwise Operator2'
     *  Selector: '<S7>/Selector'
     */
    MW_digitalWrite(arduinorobot_linefollower_P.DigitalOutput_pinNumber_g,
                    arduinorobot_linefollower_P.Constant_Value_k[s7_iter] &
                    arduinorobot_linefollower_P.BitwiseOperator2_BitMask);

    /* S-Function (arduinoanaloginput_sfcn): '<S7>/Analog Input MUX_IN' */
    rtb_AnalogInputMUX_IN_0 = MW_analogRead
      (arduinorobot_linefollower_P.AnalogInputMUX_IN_p1);

    /* Assignment: '<S7>/Assignment' incorporates:
     *  DataTypeConversion: '<S7>/Data Type Conversion'
     *  S-Function (arduinoanaloginput_sfcn): '<S7>/Analog Input MUX_IN'
     */
    rtb_Assignment[s7_iter] = (int16_T)rtb_AnalogInputMUX_IN_0;
  }

  /* End of Outputs for SubSystem: '<S4>/For Iterator Subsystem' */

  /* RelationalOperator: '<S11>/Relational Operator' incorporates:
   *  Constant: '<S5>/IR sensor threshold'
   */
  rtb_RelationalOperator = (rtb_Assignment[0] <
    arduinorobot_linefollower_P.IRsensorthreshold_Value);

  /* RelationalOperator: '<S11>/Relational Operator1' incorporates:
   *  Constant: '<S5>/IR sensor threshold'
   */
  rtb_RelationalOperator1 = (rtb_Assignment[1] <
    arduinorobot_linefollower_P.IRsensorthreshold_Value);

  /* RelationalOperator: '<S11>/Relational Operator2' incorporates:
   *  Constant: '<S5>/IR sensor threshold'
   */
  rtb_RelationalOperator2 = (rtb_Assignment[2] <
    arduinorobot_linefollower_P.IRsensorthreshold_Value);

  /* RelationalOperator: '<S11>/Relational Operator3' incorporates:
   *  Constant: '<S5>/IR sensor threshold'
   */
  rtb_RelationalOperator3 = (rtb_Assignment[3] <
    arduinorobot_linefollower_P.IRsensorthreshold_Value);

  /* RelationalOperator: '<S11>/Relational Operator4' incorporates:
   *  Constant: '<S5>/IR sensor threshold'
   */
  rtb_RelationalOperator4 = (rtb_Assignment[4] <
    arduinorobot_linefollower_P.IRsensorthreshold_Value);

  /* Sum: '<S11>/Subtract' incorporates:
   *  Constant: '<S11>/Constant'
   *  Sum: '<S11>/Sensors returning 1'
   */
  s7_iter = (int8_T)(((((arduinorobot_linefollower_P.Constant_Value_a -
    rtb_RelationalOperator) - rtb_RelationalOperator1) - rtb_RelationalOperator2)
                      - rtb_RelationalOperator3) - rtb_RelationalOperator4);

  /* Switch: '<S11>/Switch' incorporates:
   *  Constant: '<S11>/Constant3'
   */
  if (s7_iter == 0) {
    s7_iter = arduinorobot_linefollower_P.Constant3_Value;
  }

  /* End of Switch: '<S11>/Switch' */

  /* Math: '<S11>/Math Function'
   *
   * About '<S11>/Math Function':
   *  Operator: reciprocal
   */
  rtb_TSamp = div_s16_floor(64, s7_iter);
  if (rtb_TSamp > 127) {
    rtb_TSamp = 127;
  } else {
    if (rtb_TSamp < -128) {
      rtb_TSamp = -128;
    }
  }

  /* Product: '<S11>/Product' incorporates:
   *  DataTypeConversion: '<S13>/Data Type Conversion'
   *  DataTypeConversion: '<S13>/Data Type Conversion1'
   *  DataTypeConversion: '<S13>/Data Type Conversion2'
   *  DataTypeConversion: '<S13>/Data Type Conversion3'
   *  DataTypeConversion: '<S13>/Data Type Conversion4'
   *  Gain: '<S13>/IR0 weight'
   *  Gain: '<S13>/IR1 weight'
   *  Gain: '<S13>/IR2 weight'
   *  Gain: '<S13>/IR3 weight'
   *  Gain: '<S13>/IR4 weight'
   *  Math: '<S11>/Math Function'
   *  Sum: '<S11>/Add1'
   *
   * About '<S11>/Math Function':
   *  Operator: reciprocal
   */
  rtb_TSamp = (((((arduinorobot_linefollower_P.IR0weight_Gain *
                   rtb_RelationalOperator >> 4) +
                  (arduinorobot_linefollower_P.IR1weight_Gain *
                   rtb_RelationalOperator1 >> 5)) +
                 (arduinorobot_linefollower_P.IR2weight_Gain *
                  rtb_RelationalOperator2 < 0 ? -1 : 0)) +
                (arduinorobot_linefollower_P.IR3weight_Gain *
                 rtb_RelationalOperator3 >> 6)) +
               (arduinorobot_linefollower_P.IR4weight_Gain *
                rtb_RelationalOperator4 >> 5)) * (int8_T)rtb_TSamp;

  /* Sum: '<Root>/Subtract' incorporates:
   *  Constant: '<Root>/Desired deviation'
   *  Product: '<S11>/Product'
   */
  s7_iter = (int8_T)((arduinorobot_linefollower_P.Desireddeviation_Value -
                      (rtb_TSamp >> 6)) - (((rtb_TSamp & 32) != 0) &&
    (((rtb_TSamp & 31) != 0) || (rtb_TSamp > 0))));

  /* Gain: '<S1>/Derivative Gain' */
  rtb_Diff = arduinorobot_linefollower_P.DiscretePIDController_D * s7_iter;

  /* SampleTimeMath: '<S3>/TSamp'
   *
   * About '<S3>/TSamp':
   *  y = u * K where K = 1 / ( w * Ts )
   *  Multiplication by K = weightedTsampQuantized is being
   *  done implicitly by changing the scaling of the input signal.
   *  No work needs to be done here.  Downstream blocks may need
   *  to do work to handle the scaling of the output; this happens
   *  automatically.
   */
  rtb_TSamp = rtb_Diff;

  /* Sum: '<S3>/Diff' incorporates:
   *  Delay: '<S3>/UD'
   *  SampleTimeMath: '<S3>/TSamp'
   *
   * About '<S3>/TSamp':
   *  y = u * K where K = 1 / ( w * Ts )
   *  Multiplication by K = weightedTsampQuantized is being
   *  done implicitly by changing the scaling of the input signal.
   *  No work needs to be done here.  Downstream blocks may need
   *  to do work to handle the scaling of the output; this happens
   *  automatically.
   */
  rtb_Diff -= arduinorobot_linefollower_DW.UD_DSTATE;

  /* Sum: '<S1>/Sum' incorporates:
   *  DiscreteIntegrator: '<S1>/Integrator'
   *  Gain: '<S1>/Proportional Gain'
   */
  rtb_Diff = (arduinorobot_linefollower_P.DiscretePIDController_P * s7_iter +
              arduinorobot_linefollower_DW.Integrator_DSTATE) + rtb_Diff * 500;

  /* Chart: '<S5>/Torque_estimation_to_control_Motors' incorporates:
   *  Constant: '<S5>/Base torque'
   */
  /* Gateway: Robot/LineFollowerAlgorithm/Torque_estimation_to_control_Motors */
  /* During: Robot/LineFollowerAlgorithm/Torque_estimation_to_control_Motors */
  if (arduinorobot_linefollower_DW.is_active_c1_arduinorobot_linef == 0U) {
    /* Entry: Robot/LineFollowerAlgorithm/Torque_estimation_to_control_Motors */
    arduinorobot_linefollower_DW.is_active_c1_arduinorobot_linef = 1U;

    /* Entry Internal: Robot/LineFollowerAlgorithm/Torque_estimation_to_control_Motors */
    /* Transition: '<S12>:19' */
    arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
      arduinorobot_line_IN_GoStraight;

    /* Entry 'GoStraight': '<S12>:11' */
    tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
    if (tmp > 32767L) {
      tmp = 32767L;
    }

    arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
    tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
    if (tmp > 32767L) {
      tmp = 32767L;
    }

    arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
  } else {
    switch (arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower) {
     case arduinorobot_line_IN_GoStraight:
      /* During 'GoStraight': '<S12>:11' */
      if (s7_iter < 0) {
        /* Transition: '<S12>:20' */
        arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
          arduinorobot_linefo_IN_TurnLeft;

        /* Entry 'TurnLeft': '<S12>:12' */
        if (rtb_Diff < 0) {
          if (rtb_Diff <= MIN_int16_T) {
            rtb_Switch1_idx_1 = MAX_int16_T;
          } else {
            rtb_Switch1_idx_1 = -rtb_Diff;
          }
        } else {
          rtb_Switch1_idx_1 = rtb_Diff;
        }

        tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value -
          rtb_Switch1_idx_1;
        if (tmp < -32768L) {
          tmp = -32768L;
        }

        arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
        if (rtb_Diff < 0) {
          if (rtb_Diff <= MIN_int16_T) {
            rtb_Diff = MAX_int16_T;
          } else {
            rtb_Diff = -rtb_Diff;
          }
        }

        tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value + rtb_Diff;
        if (tmp > 32767L) {
          tmp = 32767L;
        }

        arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
      } else {
        if (s7_iter > 0) {
          /* Transition: '<S12>:27' */
          arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
            arduinorobot_linef_IN_TurnRight;

          /* Entry 'TurnRight': '<S12>:18' */
          if (rtb_Diff < 0) {
            if (rtb_Diff <= MIN_int16_T) {
              rtb_Switch1_idx_1 = MAX_int16_T;
            } else {
              rtb_Switch1_idx_1 = -rtb_Diff;
            }
          } else {
            rtb_Switch1_idx_1 = rtb_Diff;
          }

          tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value +
            rtb_Switch1_idx_1;
          if (tmp > 32767L) {
            tmp = 32767L;
          }

          arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
          if (rtb_Diff < 0) {
            if (rtb_Diff <= MIN_int16_T) {
              rtb_Diff = MAX_int16_T;
            } else {
              rtb_Diff = -rtb_Diff;
            }
          }

          tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value - rtb_Diff;
          if (tmp < -32768L) {
            tmp = -32768L;
          }

          arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
        }
      }
      break;

     case arduinorobot_linefo_IN_TurnLeft:
      /* During 'TurnLeft': '<S12>:12' */
      if (s7_iter > 0) {
        /* Transition: '<S12>:21' */
        arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
          arduinorobot_linef_IN_TurnRight;

        /* Entry 'TurnRight': '<S12>:18' */
        if (rtb_Diff < 0) {
          if (rtb_Diff <= MIN_int16_T) {
            rtb_Switch1_idx_1 = MAX_int16_T;
          } else {
            rtb_Switch1_idx_1 = -rtb_Diff;
          }
        } else {
          rtb_Switch1_idx_1 = rtb_Diff;
        }

        tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value +
          rtb_Switch1_idx_1;
        if (tmp > 32767L) {
          tmp = 32767L;
        }

        arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
        if (rtb_Diff < 0) {
          if (rtb_Diff <= MIN_int16_T) {
            rtb_Diff = MAX_int16_T;
          } else {
            rtb_Diff = -rtb_Diff;
          }
        }

        tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value - rtb_Diff;
        if (tmp < -32768L) {
          tmp = -32768L;
        }

        arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
      } else {
        if (s7_iter == 0) {
          /* Transition: '<S12>:23' */
          arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
            arduinorobot_line_IN_GoStraight;

          /* Entry 'GoStraight': '<S12>:11' */
          tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
          if (tmp > 32767L) {
            tmp = 32767L;
          }

          arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
          tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
          if (tmp > 32767L) {
            tmp = 32767L;
          }

          arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
        }
      }
      break;

     default:
      /* During 'TurnRight': '<S12>:18' */
      if (s7_iter == 0) {
        /* Transition: '<S12>:26' */
        arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
          arduinorobot_line_IN_GoStraight;

        /* Entry 'GoStraight': '<S12>:11' */
        tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
        if (tmp > 32767L) {
          tmp = 32767L;
        }

        arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
        tmp = 15L + arduinorobot_linefollower_P.Basetorque_Value;
        if (tmp > 32767L) {
          tmp = 32767L;
        }

        arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
      } else {
        if (s7_iter < 0) {
          /* Transition: '<S12>:28' */
          arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
            arduinorobot_linefo_IN_TurnLeft;

          /* Entry 'TurnLeft': '<S12>:12' */
          if (rtb_Diff < 0) {
            if (rtb_Diff <= MIN_int16_T) {
              rtb_Switch1_idx_1 = MAX_int16_T;
            } else {
              rtb_Switch1_idx_1 = -rtb_Diff;
            }
          } else {
            rtb_Switch1_idx_1 = rtb_Diff;
          }

          tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value -
            rtb_Switch1_idx_1;
          if (tmp < -32768L) {
            tmp = -32768L;
          }

          arduinorobot_linefollower_B.LeftTorque = (int16_T)tmp;
          if (rtb_Diff < 0) {
            if (rtb_Diff <= MIN_int16_T) {
              rtb_Diff = MAX_int16_T;
            } else {
              rtb_Diff = -rtb_Diff;
            }
          }

          tmp = (int32_T)arduinorobot_linefollower_P.Basetorque_Value + rtb_Diff;
          if (tmp > 32767L) {
            tmp = 32767L;
          }

          arduinorobot_linefollower_B.RightTorque = (int16_T)tmp;
        }
      }
      break;
    }
  }

  /* End of Chart: '<S5>/Torque_estimation_to_control_Motors' */

  /* Switch: '<S6>/Switch' incorporates:
   *  Constant: '<S6>/Constant'
   */
  if (arduinorobot_linefollower_B.LeftTorque >
      arduinorobot_linefollower_P.Switch_Threshold) {
    rtb_Diff = arduinorobot_linefollower_B.LeftTorque;
    rtb_Switch1_idx_1 = arduinorobot_linefollower_P.Constant_Value;
  } else {
    rtb_Diff = arduinorobot_linefollower_P.Constant_Value;

    /* Abs: '<S6>/Abs' incorporates:
     *  Constant: '<S6>/Constant'
     */
    if (arduinorobot_linefollower_B.LeftTorque < 0) {
      rtb_Switch1_idx_1 = -arduinorobot_linefollower_B.LeftTorque;
    } else {
      rtb_Switch1_idx_1 = arduinorobot_linefollower_B.LeftTorque;
    }

    /* End of Abs: '<S6>/Abs' */
  }

  /* End of Switch: '<S6>/Switch' */

  /* DataTypeConversion: '<S14>/Data Type Conversion' */
  if (rtb_Diff < 0) {
    rtb_Diff = 0;
  } else {
    if (rtb_Diff > 255) {
      rtb_Diff = 255;
    }
  }

  /* S-Function (arduinoanalogoutput_sfcn): '<S14>/PWM' incorporates:
   *  DataTypeConversion: '<S14>/Data Type Conversion'
   */
  MW_analogWrite(arduinorobot_linefollower_P.PWM_pinNumber, (uint8_T)rtb_Diff);

  /* DataTypeConversion: '<S15>/Data Type Conversion' */
  if (rtb_Switch1_idx_1 < 0) {
    rtb_Switch1_idx_1 = 0;
  } else {
    if (rtb_Switch1_idx_1 > 255) {
      rtb_Switch1_idx_1 = 255;
    }
  }

  /* S-Function (arduinoanalogoutput_sfcn): '<S15>/PWM' incorporates:
   *  DataTypeConversion: '<S15>/Data Type Conversion'
   */
  MW_analogWrite(arduinorobot_linefollower_P.PWM_pinNumber_m, (uint8_T)
                 rtb_Switch1_idx_1);

  /* Switch: '<S6>/Switch1' incorporates:
   *  Constant: '<S6>/Constant1'
   */
  if (arduinorobot_linefollower_B.RightTorque >
      arduinorobot_linefollower_P.Switch1_Threshold) {
    rtb_Diff = arduinorobot_linefollower_B.RightTorque;
    rtb_Switch1_idx_1 = arduinorobot_linefollower_P.Constant1_Value;
  } else {
    rtb_Diff = arduinorobot_linefollower_P.Constant1_Value;

    /* Abs: '<S6>/Abs1' incorporates:
     *  Constant: '<S6>/Constant1'
     */
    if (arduinorobot_linefollower_B.RightTorque < 0) {
      rtb_Switch1_idx_1 = -arduinorobot_linefollower_B.RightTorque;
    } else {
      rtb_Switch1_idx_1 = arduinorobot_linefollower_B.RightTorque;
    }

    /* End of Abs: '<S6>/Abs1' */
  }

  /* End of Switch: '<S6>/Switch1' */

  /* DataTypeConversion: '<S16>/Data Type Conversion' */
  if (rtb_Diff < 0) {
    rtb_Diff = 0;
  } else {
    if (rtb_Diff > 255) {
      rtb_Diff = 255;
    }
  }

  /* S-Function (arduinoanalogoutput_sfcn): '<S16>/PWM' incorporates:
   *  DataTypeConversion: '<S16>/Data Type Conversion'
   */
  MW_analogWrite(arduinorobot_linefollower_P.PWM_pinNumber_i, (uint8_T)rtb_Diff);

  /* DataTypeConversion: '<S17>/Data Type Conversion' */
  if (rtb_Switch1_idx_1 < 0) {
    rtb_Switch1_idx_1 = 0;
  } else {
    if (rtb_Switch1_idx_1 > 255) {
      rtb_Switch1_idx_1 = 255;
    }
  }

  /* S-Function (arduinoanalogoutput_sfcn): '<S17>/PWM' incorporates:
   *  DataTypeConversion: '<S17>/Data Type Conversion'
   */
  MW_analogWrite(arduinorobot_linefollower_P.PWM_pinNumber_f, (uint8_T)
                 rtb_Switch1_idx_1);

  /* Update for Delay: '<S3>/UD' */
  arduinorobot_linefollower_DW.UD_DSTATE = rtb_TSamp;

  /* Update for DiscreteIntegrator: '<S1>/Integrator' incorporates:
   *  Gain: '<S1>/Integral Gain'
   */
  tmp = (int32_T)(arduinorobot_linefollower_P.DiscretePIDController_I * s7_iter)
    * arduinorobot_linefollower_P.Integrator_gainval;
  arduinorobot_linefollower_DW.Integrator_DSTATE += (((tmp & 4194304L) != 0L) &&
    (((tmp & 4194303L) != 0L) || (tmp > 0L))) + (int16_T)(tmp >> 23);
}

/* Model initialize function */
void arduinorobot_linefollower_initialize(void)
{
  /* Registration code */

  /* initialize error status */
  rtmSetErrorStatus(arduinorobot_linefollower_M, (NULL));

  /* block I/O */
  (void) memset(((void *) &arduinorobot_linefollower_B), 0,
                sizeof(B_arduinorobot_linefollower_T));

  /* states (dwork) */
  (void) memset((void *)&arduinorobot_linefollower_DW, 0,
                sizeof(DW_arduinorobot_linefollower_T));

  /* Start for Iterator SubSystem: '<S4>/For Iterator Subsystem' */
  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S8>/Digital Output' */
  MW_pinModeOutput(arduinorobot_linefollower_P.DigitalOutput_pinNumber);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S9>/Digital Output' */
  MW_pinModeOutput(arduinorobot_linefollower_P.DigitalOutput_pinNumber_e);

  /* Start for S-Function (arduinodigitaloutput_sfcn): '<S10>/Digital Output' */
  MW_pinModeOutput(arduinorobot_linefollower_P.DigitalOutput_pinNumber_g);

  /* Start for S-Function (arduinoanaloginput_sfcn): '<S7>/Analog Input MUX_IN' */
  MW_pinModeAnalogInput(arduinorobot_linefollower_P.AnalogInputMUX_IN_p1);

  /* End of Start for SubSystem: '<S4>/For Iterator Subsystem' */

  /* Start for S-Function (arduinoanalogoutput_sfcn): '<S14>/PWM' */
  MW_pinModeOutput(arduinorobot_linefollower_P.PWM_pinNumber);

  /* Start for S-Function (arduinoanalogoutput_sfcn): '<S15>/PWM' */
  MW_pinModeOutput(arduinorobot_linefollower_P.PWM_pinNumber_m);

  /* Start for S-Function (arduinoanalogoutput_sfcn): '<S16>/PWM' */
  MW_pinModeOutput(arduinorobot_linefollower_P.PWM_pinNumber_i);

  /* Start for S-Function (arduinoanalogoutput_sfcn): '<S17>/PWM' */
  MW_pinModeOutput(arduinorobot_linefollower_P.PWM_pinNumber_f);

  /* InitializeConditions for Delay: '<S3>/UD' */
  arduinorobot_linefollower_DW.UD_DSTATE =
    arduinorobot_linefollower_P.UD_InitialCondition;

  /* InitializeConditions for DiscreteIntegrator: '<S1>/Integrator' */
  arduinorobot_linefollower_DW.Integrator_DSTATE =
    arduinorobot_linefollower_P.Integrator_IC;

  /* InitializeConditions for Chart: '<S5>/Torque_estimation_to_control_Motors' */
  arduinorobot_linefollower_DW.is_active_c1_arduinorobot_linef = 0U;
  arduinorobot_linefollower_DW.is_c1_arduinorobot_linefollower =
    arduinorobot_IN_NO_ACTIVE_CHILD;
}

/* Model terminate function */
void arduinorobot_linefollower_terminate(void)
{
  /* (no terminate code required) */
}

/*
 * File trailer for generated code.
 *
 * [EOF]
 */
