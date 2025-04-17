using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000450 RID: 1104
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x06005FCD RID: 24525 RVA: 0x001B749C File Offset: 0x001B569C
		// Note: this type is marked as 'beforefieldinit'.
		static BirdsEyeView()
		{
			Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "BirdsEyeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr);
			BirdsEyeView.NativeFieldInfoPtr_bounds_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Min");
			BirdsEyeView.NativeFieldInfoPtr_bounds_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Max");
			BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "lateralMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "scrollMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetFollowSpeed");
			BirdsEyeView.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "xSpeed");
			BirdsEyeView.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "ySpeed");
			BirdsEyeView.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMinLimit");
			BirdsEyeView.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMaxLimit");
			BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "rotationOriginPoint");
			BirdsEyeView.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "distance");
			BirdsEyeView.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "prevDistance");
			BirdsEyeView.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "x");
			BirdsEyeView.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "y");
			BirdsEyeView.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetTransform");
			BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<isEnabled>k__BackingField");
			BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "originSlideRoutine");
			BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675513);
			BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675514);
			BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675515);
			BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675516);
			BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675517);
			BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675518);
			BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675519);
			BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675520);
			BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675521);
			BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675522);
			BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675523);
			BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675524);
			BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675525);
			BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675526);
			BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675527);
			BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675528);
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06005FCE RID: 24526 RVA: 0x001B7760 File Offset: 0x001B5960
		public unsafe Transform playerCam
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 198612, RefRangeEnd = 198619, XrefRangeStart = 198606, XrefRangeEnd = 198612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06005FCF RID: 24527 RVA: 0x001B77A0 File Offset: 0x001B59A0
		// (set) Token: 0x06005FD0 RID: 24528 RVA: 0x001B77DC File Offset: 0x001B59DC
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x001B781C File Offset: 0x001B5A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198619, XrefRangeEnd = 198636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x001B7858 File Offset: 0x001B5A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198636, XrefRangeEnd = 198639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x001B7894 File Offset: 0x001B5A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198639, XrefRangeEnd = 198640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x001B78D0 File Offset: 0x001B5AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198640, XrefRangeEnd = 198653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(Vector3 startPosition, Quaternion startRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x001B791C File Offset: 0x001B5B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198662, RefRangeEnd = 198663, XrefRangeStart = 198653, XrefRangeEnd = 198662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable(bool reenableCameraLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableCameraLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x001B795C File Offset: 0x001B5B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198688, RefRangeEnd = 198689, XrefRangeStart = 198663, XrefRangeEnd = 198688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLateralMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x001B7990 File Offset: 0x001B5B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198703, RefRangeEnd = 198704, XrefRangeStart = 198689, XrefRangeEnd = 198703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x001B79C4 File Offset: 0x001B5BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198736, RefRangeEnd = 198737, XrefRangeStart = 198704, XrefRangeEnd = 198736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x001B79F8 File Offset: 0x001B5BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198751, RefRangeEnd = 198752, XrefRangeStart = 198737, XrefRangeEnd = 198751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x001B7A2C File Offset: 0x001B5C2C
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x001B7A88 File Offset: 0x001B5C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198752, XrefRangeEnd = 198754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelOriginSlide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x001B7ABC File Offset: 0x001B5CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198779, RefRangeEnd = 198780, XrefRangeStart = 198754, XrefRangeEnd = 198779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x001B7B18 File Offset: 0x001B5D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198780, XrefRangeEnd = 198785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BirdsEyeView() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x0002D34E File Offset: 0x0002B54E
		public BirdsEyeView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x001B7B54 File Offset: 0x001B5D54
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x0002D357 File Offset: 0x0002B557
		public unsafe Vector3 bounds_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min)) = value;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x001B7B7C File Offset: 0x001B5D7C
		// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x0002D372 File Offset: 0x0002B572
		public unsafe Vector3 bounds_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max)) = value;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x001B7BA4 File Offset: 0x001B5DA4
		// (set) Token: 0x06005FE4 RID: 24548 RVA: 0x0002D38D File Offset: 0x0002B58D
		public unsafe float lateralMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed)) = value;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06005FE5 RID: 24549 RVA: 0x001B7BCC File Offset: 0x001B5DCC
		// (set) Token: 0x06005FE6 RID: 24550 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
		public unsafe float scrollMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed)) = value;
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x001B7BF4 File Offset: 0x001B5DF4
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x0002D3C3 File Offset: 0x0002B5C3
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x001B7C1C File Offset: 0x001B5E1C
		// (set) Token: 0x06005FEA RID: 24554 RVA: 0x0002D3DE File Offset: 0x0002B5DE
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x001B7C44 File Offset: 0x001B5E44
		// (set) Token: 0x06005FEC RID: 24556 RVA: 0x0002D3F9 File Offset: 0x0002B5F9
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x001B7C6C File Offset: 0x001B5E6C
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x0002D414 File Offset: 0x0002B614
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x001B7C94 File Offset: 0x001B5E94
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x0002D42F File Offset: 0x0002B62F
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x001B7CBC File Offset: 0x001B5EBC
		// (set) Token: 0x06005FF2 RID: 24562 RVA: 0x0002D44A File Offset: 0x0002B64A
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x001B7CE4 File Offset: 0x001B5EE4
		// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x0002D465 File Offset: 0x0002B665
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x001B7D0C File Offset: 0x001B5F0C
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x0002D480 File Offset: 0x0002B680
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x001B7D34 File Offset: 0x001B5F34
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x0002D49B File Offset: 0x0002B69B
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x001B7D5C File Offset: 0x001B5F5C
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x0002D4B6 File Offset: 0x0002B6B6
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x001B7D84 File Offset: 0x001B5F84
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x0002D4D1 File Offset: 0x0002B6D1
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x001B7DB4 File Offset: 0x001B5FB4
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x001B7DDC File Offset: 0x001B5FDC
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x0002D50B File Offset: 0x0002B70B
		public unsafe Coroutine originSlideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004172 RID: 16754
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Min;

		// Token: 0x04004173 RID: 16755
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Max;

		// Token: 0x04004174 RID: 16756
		private static readonly IntPtr NativeFieldInfoPtr_lateralMovementSpeed;

		// Token: 0x04004175 RID: 16757
		private static readonly IntPtr NativeFieldInfoPtr_scrollMovementSpeed;

		// Token: 0x04004176 RID: 16758
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x04004177 RID: 16759
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004178 RID: 16760
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004179 RID: 16761
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x0400417A RID: 16762
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x0400417B RID: 16763
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x0400417C RID: 16764
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x0400417D RID: 16765
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x0400417E RID: 16766
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400417F RID: 16767
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004180 RID: 16768
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04004181 RID: 16769
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x04004182 RID: 16770
		private static readonly IntPtr NativeFieldInfoPtr_originSlideRoutine;

		// Token: 0x04004183 RID: 16771
		private static readonly IntPtr NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0;

		// Token: 0x04004184 RID: 16772
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x04004185 RID: 16773
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04004186 RID: 16774
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004187 RID: 16775
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004188 RID: 16776
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004189 RID: 16777
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0;

		// Token: 0x0400418A RID: 16778
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_Boolean_0;

		// Token: 0x0400418B RID: 16779
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0;

		// Token: 0x0400418C RID: 16780
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0;

		// Token: 0x0400418D RID: 16781
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x0400418E RID: 16782
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x0400418F RID: 16783
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004190 RID: 16784
		private static readonly IntPtr NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0;

		// Token: 0x04004191 RID: 16785
		private static readonly IntPtr NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0;

		// Token: 0x04004192 RID: 16786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A0E RID: 2574
		[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEA3 RID: 52899 RVA: 0x0031B084 File Offset: 0x00319284
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr);
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "position");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "time");
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675529);
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675530);
			}

			// Token: 0x0600CEA4 RID: 52900 RVA: 0x0031B114 File Offset: 0x00319314
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEA5 RID: 52901 RVA: 0x0031B150 File Offset: 0x00319350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198601, XrefRangeEnd = 198606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CEA6 RID: 52902 RVA: 0x000647EA File Offset: 0x000629EA
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004042 RID: 16450
			// (get) Token: 0x0600CEA7 RID: 52903 RVA: 0x0031B190 File Offset: 0x00319390
			// (set) Token: 0x0600CEA8 RID: 52904 RVA: 0x000647F3 File Offset: 0x000629F3
			public unsafe BirdsEyeView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004043 RID: 16451
			// (get) Token: 0x0600CEA9 RID: 52905 RVA: 0x0031B1C0 File Offset: 0x003193C0
			// (set) Token: 0x0600CEAA RID: 52906 RVA: 0x00064812 File Offset: 0x00062A12
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004044 RID: 16452
			// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x0031B1E8 File Offset: 0x003193E8
			// (set) Token: 0x0600CEAC RID: 52908 RVA: 0x0006482D File Offset: 0x00062A2D
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008B72 RID: 35698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B73 RID: 35699
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008B74 RID: 35700
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008B75 RID: 35701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B76 RID: 35702
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C55 RID: 3157
			[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0+<<SlideCameraOrigin>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E350 RID: 58192 RVA: 0x00355B14 File Offset: 0x00353D14
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique()
				{
					Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<<SlideCameraOrigin>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>1__state");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>2__current");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>4__this");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<i>5__3");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675531);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675532);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675533);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675534);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675535);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675536);
				}

				// Token: 0x0600E351 RID: 58193 RVA: 0x00355C1C File Offset: 0x00353E1C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E352 RID: 58194 RVA: 0x00355C64 File Offset: 0x00353E64
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E353 RID: 58195 RVA: 0x00355C98 File Offset: 0x00353E98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198585, XrefRangeEnd = 198596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700468A RID: 18058
				// (get) Token: 0x0600E354 RID: 58196 RVA: 0x00355CD4 File Offset: 0x00353ED4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E355 RID: 58197 RVA: 0x00355D14 File Offset: 0x00353F14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198596, XrefRangeEnd = 198601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700468B RID: 18059
				// (get) Token: 0x0600E356 RID: 58198 RVA: 0x00355D48 File Offset: 0x00353F48
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E357 RID: 58199 RVA: 0x0006EC8F File Offset: 0x0006CE8F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004685 RID: 18053
				// (get) Token: 0x0600E358 RID: 58200 RVA: 0x00355D88 File Offset: 0x00353F88
				// (set) Token: 0x0600E359 RID: 58201 RVA: 0x0006EC98 File Offset: 0x0006CE98
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004686 RID: 18054
				// (get) Token: 0x0600E35A RID: 58202 RVA: 0x00355DB0 File Offset: 0x00353FB0
				// (set) Token: 0x0600E35B RID: 58203 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004687 RID: 18055
				// (get) Token: 0x0600E35C RID: 58204 RVA: 0x00355DE0 File Offset: 0x00353FE0
				// (set) Token: 0x0600E35D RID: 58205 RVA: 0x0006ECD2 File Offset: 0x0006CED2
				public unsafe BirdsEyeView.__c__DisplayClass33_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView.__c__DisplayClass33_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004688 RID: 18056
				// (get) Token: 0x0600E35E RID: 58206 RVA: 0x00355E10 File Offset: 0x00354010
				// (set) Token: 0x0600E35F RID: 58207 RVA: 0x0006ECF1 File Offset: 0x0006CEF1
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17004689 RID: 18057
				// (get) Token: 0x0600E360 RID: 58208 RVA: 0x00355E38 File Offset: 0x00354038
				// (set) Token: 0x0600E361 RID: 58209 RVA: 0x0006ED0C File Offset: 0x0006CF0C
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400981E RID: 38942
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400981F RID: 38943
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009820 RID: 38944
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009821 RID: 38945
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x04009822 RID: 38946
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009823 RID: 38947
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009824 RID: 38948
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009825 RID: 38949
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009826 RID: 38950
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009827 RID: 38951
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009828 RID: 38952
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
