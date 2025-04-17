using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E9 RID: 1257
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x06006EEB RID: 28395 RVA: 0x001EA138 File Offset: 0x001E8338
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCamera()
		{
			Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr);
			VehicleCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "followDelta");
			VehicleCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMinLimit");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideTime");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideReturnTime");
			VehicleCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "xSpeed");
			VehicleCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "ySpeed");
			VehicleCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMaxLimit");
			VehicleCamera.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "vehicle");
			VehicleCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraOrigin");
			VehicleCamera.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lateralOffset");
			VehicleCamera.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "verticalOffset");
			VehicleCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraReversed");
			VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			VehicleCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "orbitDistance");
			VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastFrameCameraOffset");
			VehicleCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastManualOffset");
			VehicleCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "targetTransform");
			VehicleCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraDolly");
			VehicleCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "x");
			VehicleCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "y");
			VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677315);
			VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677316);
			VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677317);
			VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677318);
			VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677319);
			VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677320);
			VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677321);
			VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677322);
			VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677323);
			VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677324);
			VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677325);
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x001EA3D4 File Offset: 0x001E85D4
		public unsafe Transform cam
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 220349, RefRangeEnd = 220364, XrefRangeStart = 220343, XrefRangeEnd = 220349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x001EA414 File Offset: 0x001E8614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220364, XrefRangeEnd = 220433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x001EA450 File Offset: 0x001E8650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220433, XrefRangeEnd = 220451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x001EA484 File Offset: 0x001E8684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220467, RefRangeEnd = 220468, XrefRangeStart = 220451, XrefRangeEnd = 220467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x001EA4C0 File Offset: 0x001E86C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220468, XrefRangeEnd = 220479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnteredVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x001EA504 File Offset: 0x001E8704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220479, XrefRangeEnd = 220494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x001EA538 File Offset: 0x001E8738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220595, RefRangeEnd = 220596, XrefRangeStart = 220494, XrefRangeEnd = 220595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x001EA574 File Offset: 0x001E8774
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x001EA5D0 File Offset: 0x001E87D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220596, XrefRangeEnd = 220603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x001EA60C File Offset: 0x001E880C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220630, RefRangeEnd = 220633, XrefRangeStart = 220603, XrefRangeEnd = 220630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x001EA658 File Offset: 0x001E8858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220638, RefRangeEnd = 220639, XrefRangeStart = 220633, XrefRangeEnd = 220638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x000347F7 File Offset: 0x000329F7
		public VehicleCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x001EA694 File Offset: 0x001E8894
		// (set) Token: 0x06006EF9 RID: 28409 RVA: 0x00034800 File Offset: 0x00032A00
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006EFA RID: 28410 RVA: 0x001EA6B0 File Offset: 0x001E88B0
		// (set) Token: 0x06006EFB RID: 28411 RVA: 0x0003480E File Offset: 0x00032A0E
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006EFC RID: 28412 RVA: 0x001EA6CC File Offset: 0x001E88CC
		// (set) Token: 0x06006EFD RID: 28413 RVA: 0x0003481C File Offset: 0x00032A1C
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x001EA6E8 File Offset: 0x001E88E8
		// (set) Token: 0x06006EFF RID: 28415 RVA: 0x0003482A File Offset: 0x00032A2A
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006F00 RID: 28416 RVA: 0x001EA704 File Offset: 0x001E8904
		// (set) Token: 0x06006F01 RID: 28417 RVA: 0x00034838 File Offset: 0x00032A38
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06006F02 RID: 28418 RVA: 0x001EA720 File Offset: 0x001E8920
		// (set) Token: 0x06006F03 RID: 28419 RVA: 0x00034846 File Offset: 0x00032A46
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06006F04 RID: 28420 RVA: 0x001EA73C File Offset: 0x001E893C
		// (set) Token: 0x06006F05 RID: 28421 RVA: 0x00034854 File Offset: 0x00032A54
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x001EA758 File Offset: 0x001E8958
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x00034862 File Offset: 0x00032A62
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x001EA788 File Offset: 0x001E8988
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x00034881 File Offset: 0x00032A81
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x001EA7B8 File Offset: 0x001E89B8
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x000348A0 File Offset: 0x00032AA0
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06006F0C RID: 28428 RVA: 0x001EA7E0 File Offset: 0x001E89E0
		// (set) Token: 0x06006F0D RID: 28429 RVA: 0x000348BB File Offset: 0x00032ABB
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x001EA808 File Offset: 0x001E8A08
		// (set) Token: 0x06006F0F RID: 28431 RVA: 0x000348D6 File Offset: 0x00032AD6
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x001EA830 File Offset: 0x001E8A30
		// (set) Token: 0x06006F11 RID: 28433 RVA: 0x000348F1 File Offset: 0x00032AF1
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x001EA858 File Offset: 0x001E8A58
		// (set) Token: 0x06006F13 RID: 28435 RVA: 0x0003490C File Offset: 0x00032B0C
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x001EA880 File Offset: 0x001E8A80
		// (set) Token: 0x06006F15 RID: 28437 RVA: 0x00034927 File Offset: 0x00032B27
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x001EA8A8 File Offset: 0x001E8AA8
		// (set) Token: 0x06006F17 RID: 28439 RVA: 0x00034942 File Offset: 0x00032B42
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x001EA8D0 File Offset: 0x001E8AD0
		// (set) Token: 0x06006F19 RID: 28441 RVA: 0x0003495D File Offset: 0x00032B5D
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x001EA900 File Offset: 0x001E8B00
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x0003497C File Offset: 0x00032B7C
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x001EA930 File Offset: 0x001E8B30
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x0003499B File Offset: 0x00032B9B
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x001EA958 File Offset: 0x001E8B58
		// (set) Token: 0x06006F1F RID: 28447 RVA: 0x000349B6 File Offset: 0x00032BB6
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x04004BDE RID: 19422
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x04004BDF RID: 19423
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004BE0 RID: 19424
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x04004BE1 RID: 19425
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x04004BE2 RID: 19426
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004BE3 RID: 19427
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004BE4 RID: 19428
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004BE5 RID: 19429
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004BE6 RID: 19430
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004BE7 RID: 19431
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004BE8 RID: 19432
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x04004BE9 RID: 19433
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x04004BEA RID: 19434
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x04004BEB RID: 19435
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x04004BEC RID: 19436
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04004BED RID: 19437
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04004BEE RID: 19438
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04004BEF RID: 19439
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04004BF0 RID: 19440
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04004BF1 RID: 19441
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004BF2 RID: 19442
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04004BF3 RID: 19443
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004BF4 RID: 19444
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04004BF5 RID: 19445
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004BF6 RID: 19446
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04004BF7 RID: 19447
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_0;

		// Token: 0x04004BF8 RID: 19448
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BF9 RID: 19449
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004BFA RID: 19450
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x04004BFB RID: 19451
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x04004BFC RID: 19452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
