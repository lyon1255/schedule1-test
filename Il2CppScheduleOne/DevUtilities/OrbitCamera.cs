using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000460 RID: 1120
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06006145 RID: 24901 RVA: 0x001BBD38 File Offset: 0x001B9F38
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitCamera()
		{
			Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OrbitCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
			OrbitCamera.NativeFieldInfoPtr_cameraStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraStartPoint");
			OrbitCamera.NativeFieldInfoPtr_centrePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "centrePoint");
			OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetFollowSpeed");
			OrbitCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMinLimit");
			OrbitCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMaxLimit");
			OrbitCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "xSpeed");
			OrbitCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "ySpeed");
			OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "<isEnabled>k__BackingField");
			OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "rotationOriginPoint");
			OrbitCamera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "distance");
			OrbitCamera.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "prevDistance");
			OrbitCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "x");
			OrbitCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "y");
			OrbitCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetTransform");
			OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675659);
			OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675660);
			OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675661);
			OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675662);
			OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675663);
			OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675664);
			OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675665);
			OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675666);
			OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675667);
			OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675668);
			OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675669);
			OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675670);
			OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675671);
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06006146 RID: 24902 RVA: 0x001BBF84 File Offset: 0x001BA184
		// (set) Token: 0x06006147 RID: 24903 RVA: 0x001BBFC0 File Offset: 0x001BA1C0
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06006148 RID: 24904 RVA: 0x001BC000 File Offset: 0x001BA200
		public unsafe Transform cam
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 200480, RefRangeEnd = 200486, XrefRangeStart = 200474, XrefRangeEnd = 200480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x001BC040 File Offset: 0x001BA240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200486, XrefRangeEnd = 200500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x001BC07C File Offset: 0x001BA27C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x001BC0B8 File Offset: 0x001BA2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200500, XrefRangeEnd = 200501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x001BC0F4 File Offset: 0x001BA2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200501, XrefRangeEnd = 200502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x001BC130 File Offset: 0x001BA330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200524, RefRangeEnd = 200525, XrefRangeStart = 200502, XrefRangeEnd = 200524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x001BC164 File Offset: 0x001BA364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200534, RefRangeEnd = 200536, XrefRangeStart = 200525, XrefRangeEnd = 200534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x001BC198 File Offset: 0x001BA398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200565, RefRangeEnd = 200566, XrefRangeStart = 200536, XrefRangeEnd = 200565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x001BC1CC File Offset: 0x001BA3CC
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x001BC228 File Offset: 0x001BA428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200580, RefRangeEnd = 200581, XrefRangeStart = 200566, XrefRangeEnd = 200580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x001BC25C File Offset: 0x001BA45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200581, XrefRangeEnd = 200584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x0002DF91 File Offset: 0x0002C191
		public OrbitCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06006154 RID: 24916 RVA: 0x001BC298 File Offset: 0x001BA498
		// (set) Token: 0x06006155 RID: 24917 RVA: 0x0002DF9A File Offset: 0x0002C19A
		public unsafe Transform cameraStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x001BC2C8 File Offset: 0x001BA4C8
		// (set) Token: 0x06006157 RID: 24919 RVA: 0x0002DFB9 File Offset: 0x0002C1B9
		public unsafe Transform centrePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x001BC2F8 File Offset: 0x001BA4F8
		// (set) Token: 0x06006159 RID: 24921 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x0600615A RID: 24922 RVA: 0x001BC320 File Offset: 0x001BA520
		// (set) Token: 0x0600615B RID: 24923 RVA: 0x0002DFF3 File Offset: 0x0002C1F3
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x0600615C RID: 24924 RVA: 0x001BC348 File Offset: 0x001BA548
		// (set) Token: 0x0600615D RID: 24925 RVA: 0x0002E00E File Offset: 0x0002C20E
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600615E RID: 24926 RVA: 0x001BC370 File Offset: 0x001BA570
		// (set) Token: 0x0600615F RID: 24927 RVA: 0x0002E029 File Offset: 0x0002C229
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x001BC38C File Offset: 0x001BA58C
		// (set) Token: 0x06006161 RID: 24929 RVA: 0x0002E037 File Offset: 0x0002C237
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x001BC3A8 File Offset: 0x001BA5A8
		// (set) Token: 0x06006163 RID: 24931 RVA: 0x0002E045 File Offset: 0x0002C245
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x001BC3D0 File Offset: 0x001BA5D0
		// (set) Token: 0x06006165 RID: 24933 RVA: 0x0002E060 File Offset: 0x0002C260
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x001BC3F8 File Offset: 0x001BA5F8
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x0002E07B File Offset: 0x0002C27B
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x001BC420 File Offset: 0x001BA620
		// (set) Token: 0x06006169 RID: 24937 RVA: 0x0002E096 File Offset: 0x0002C296
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x001BC448 File Offset: 0x001BA648
		// (set) Token: 0x0600616B RID: 24939 RVA: 0x0002E0B1 File Offset: 0x0002C2B1
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x001BC470 File Offset: 0x001BA670
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x0002E0CC File Offset: 0x0002C2CC
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x001BC498 File Offset: 0x001BA698
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x0002E0E7 File Offset: 0x0002C2E7
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeFieldInfoPtr_cameraStartPoint;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeFieldInfoPtr_centrePoint;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Protected_get_Transform_0;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
