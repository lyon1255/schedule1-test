using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F4 RID: 1524
	public class Eye : MonoBehaviour
	{
		// Token: 0x0600861F RID: 34335 RVA: 0x00238114 File Offset: 0x00236314
		// Note: this type is marked as 'beforefieldinit'.
		static Eye()
		{
			Il2CppClassPointerStore<Eye>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eye");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye>.NativeClassPtr);
			Eye.NativeFieldInfoPtr_PupilLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilLookSpeed");
			Eye.NativeFieldInfoPtr_defaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultScale");
			Eye.NativeFieldInfoPtr_maxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "maxRotation");
			Eye.NativeFieldInfoPtr_minRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "minRotation");
			Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<CurrentConfiguration>k__BackingField");
			Eye.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "Container");
			Eye.NativeFieldInfoPtr_TopLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidContainer");
			Eye.NativeFieldInfoPtr_BottomLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidContainer");
			Eye.NativeFieldInfoPtr_PupilContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilContainer");
			Eye.NativeFieldInfoPtr_TopLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidRend");
			Eye.NativeFieldInfoPtr_BottomLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidRend");
			Eye.NativeFieldInfoPtr_EyeBallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeBallRend");
			Eye.NativeFieldInfoPtr_EyeLookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLookOrigin");
			Eye.NativeFieldInfoPtr_EyeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLight");
			Eye.NativeFieldInfoPtr_PupilRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilRend");
			Eye.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "blinkRoutine");
			Eye.NativeFieldInfoPtr_stateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "stateRoutine");
			Eye.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "avatar");
			Eye.NativeFieldInfoPtr_defaultEyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultEyeColor");
			Eye.NativeFieldInfoPtr_AngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "AngleOffset");
			Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680050);
			Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680051);
			Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680052);
			Eye.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680053);
			Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680054);
			Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680055);
			Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680056);
			Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680057);
			Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680058);
			Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680059);
			Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680060);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680061);
			Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680062);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680063);
			Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680064);
			Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680065);
			Eye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680066);
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x06008620 RID: 34336 RVA: 0x00238428 File Offset: 0x00236628
		// (set) Token: 0x06008621 RID: 34337 RVA: 0x00238464 File Offset: 0x00236664
		public unsafe Eye.EyeLidConfiguration CurrentConfiguration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54187, RefRangeEnd = 54188, XrefRangeStart = 54187, XrefRangeEnd = 54188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x002384A4 File Offset: 0x002366A4
		public unsafe bool IsBlinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x002384E0 File Offset: 0x002366E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250517, XrefRangeEnd = 250521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008624 RID: 34340 RVA: 0x00238514 File Offset: 0x00236714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250526, RefRangeEnd = 250528, XrefRangeStart = 250521, XrefRangeEnd = 250526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008625 RID: 34341 RVA: 0x00238554 File Offset: 0x00236754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250528, XrefRangeEnd = 250532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLidColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x00238594 File Offset: 0x00236794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250532, XrefRangeEnd = 250534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballMaterial(Material mat, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x002385E4 File Offset: 0x002367E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 250540, RefRangeEnd = 250552, XrefRangeStart = 250534, XrefRangeEnd = 250540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x00238640 File Offset: 0x00236840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250558, RefRangeEnd = 250562, XrefRangeStart = 250552, XrefRangeEnd = 250558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x00238674 File Offset: 0x00236874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250571, RefRangeEnd = 250573, XrefRangeStart = 250562, XrefRangeEnd = 250571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureEyeLight(Color color, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x002386C0 File Offset: 0x002368C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250573, XrefRangeEnd = 250575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDilation(float dil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x00238700 File Offset: 0x00236900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250596, RefRangeEnd = 250598, XrefRangeStart = 250575, XrefRangeEnd = 250596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x0023874C File Offset: 0x0023694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250598, XrefRangeEnd = 250600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopExistingRoutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x00238780 File Offset: 0x00236980
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 250629, RefRangeEnd = 250639, XrefRangeStart = 250600, XrefRangeEnd = 250629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x002387CC File Offset: 0x002369CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250667, RefRangeEnd = 250669, XrefRangeStart = 250639, XrefRangeEnd = 250667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x00238818 File Offset: 0x00236A18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250693, RefRangeEnd = 250699, XrefRangeStart = 250669, XrefRangeEnd = 250693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blinkDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x00238874 File Offset: 0x00236A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250699, XrefRangeEnd = 250702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eye() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x0003FB83 File Offset: 0x0003DD83
		public Eye(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x06008632 RID: 34354 RVA: 0x002388B0 File Offset: 0x00236AB0
		// (set) Token: 0x06008633 RID: 34355 RVA: 0x0003FB8C File Offset: 0x0003DD8C
		public unsafe static float PupilLookSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&value));
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x06008634 RID: 34356 RVA: 0x002388CC File Offset: 0x00236ACC
		// (set) Token: 0x06008635 RID: 34357 RVA: 0x0003FB9A File Offset: 0x0003DD9A
		public unsafe static Vector3 defaultScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&value));
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x06008636 RID: 34358 RVA: 0x002388E8 File Offset: 0x00236AE8
		// (set) Token: 0x06008637 RID: 34359 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
		public unsafe static Vector3 maxRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&value));
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x06008638 RID: 34360 RVA: 0x00238904 File Offset: 0x00236B04
		// (set) Token: 0x06008639 RID: 34361 RVA: 0x0003FBB6 File Offset: 0x0003DDB6
		public unsafe static Vector3 minRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&value));
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600863A RID: 34362 RVA: 0x00238920 File Offset: 0x00236B20
		// (set) Token: 0x0600863B RID: 34363 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		public unsafe Eye.EyeLidConfiguration _CurrentConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField)) = value;
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600863C RID: 34364 RVA: 0x00238948 File Offset: 0x00236B48
		// (set) Token: 0x0600863D RID: 34365 RVA: 0x0003FBDF File Offset: 0x0003DDDF
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600863E RID: 34366 RVA: 0x00238978 File Offset: 0x00236B78
		// (set) Token: 0x0600863F RID: 34367 RVA: 0x0003FBFE File Offset: 0x0003DDFE
		public unsafe Transform TopLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x06008640 RID: 34368 RVA: 0x002389A8 File Offset: 0x00236BA8
		// (set) Token: 0x06008641 RID: 34369 RVA: 0x0003FC1D File Offset: 0x0003DE1D
		public unsafe Transform BottomLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x06008642 RID: 34370 RVA: 0x002389D8 File Offset: 0x00236BD8
		// (set) Token: 0x06008643 RID: 34371 RVA: 0x0003FC3C File Offset: 0x0003DE3C
		public unsafe Transform PupilContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x00238A08 File Offset: 0x00236C08
		// (set) Token: 0x06008645 RID: 34373 RVA: 0x0003FC5B File Offset: 0x0003DE5B
		public unsafe MeshRenderer TopLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x06008646 RID: 34374 RVA: 0x00238A38 File Offset: 0x00236C38
		// (set) Token: 0x06008647 RID: 34375 RVA: 0x0003FC7A File Offset: 0x0003DE7A
		public unsafe MeshRenderer BottomLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x06008648 RID: 34376 RVA: 0x00238A68 File Offset: 0x00236C68
		// (set) Token: 0x06008649 RID: 34377 RVA: 0x0003FC99 File Offset: 0x0003DE99
		public unsafe MeshRenderer EyeBallRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600864A RID: 34378 RVA: 0x00238A98 File Offset: 0x00236C98
		// (set) Token: 0x0600864B RID: 34379 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
		public unsafe Transform EyeLookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x00238AC8 File Offset: 0x00236CC8
		// (set) Token: 0x0600864D RID: 34381 RVA: 0x0003FCD7 File Offset: 0x0003DED7
		public unsafe OptimizedLight EyeLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600864E RID: 34382 RVA: 0x00238AF8 File Offset: 0x00236CF8
		// (set) Token: 0x0600864F RID: 34383 RVA: 0x0003FCF6 File Offset: 0x0003DEF6
		public unsafe SkinnedMeshRenderer PupilRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00238B28 File Offset: 0x00236D28
		// (set) Token: 0x06008651 RID: 34385 RVA: 0x0003FD15 File Offset: 0x0003DF15
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x06008652 RID: 34386 RVA: 0x00238B58 File Offset: 0x00236D58
		// (set) Token: 0x06008653 RID: 34387 RVA: 0x0003FD34 File Offset: 0x0003DF34
		public unsafe Coroutine stateRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x00238B88 File Offset: 0x00236D88
		// (set) Token: 0x06008655 RID: 34389 RVA: 0x0003FD53 File Offset: 0x0003DF53
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x00238BB8 File Offset: 0x00236DB8
		// (set) Token: 0x06008657 RID: 34391 RVA: 0x0003FD72 File Offset: 0x0003DF72
		public unsafe Color defaultEyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor)) = value;
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x00238BE0 File Offset: 0x00236DE0
		// (set) Token: 0x06008659 RID: 34393 RVA: 0x0003FD8D File Offset: 0x0003DF8D
		public unsafe Vector2 AngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset)) = value;
			}
		}

		// Token: 0x04005B51 RID: 23377
		private static readonly IntPtr NativeFieldInfoPtr_PupilLookSpeed;

		// Token: 0x04005B52 RID: 23378
		private static readonly IntPtr NativeFieldInfoPtr_defaultScale;

		// Token: 0x04005B53 RID: 23379
		private static readonly IntPtr NativeFieldInfoPtr_maxRotation;

		// Token: 0x04005B54 RID: 23380
		private static readonly IntPtr NativeFieldInfoPtr_minRotation;

		// Token: 0x04005B55 RID: 23381
		private static readonly IntPtr NativeFieldInfoPtr__CurrentConfiguration_k__BackingField;

		// Token: 0x04005B56 RID: 23382
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005B57 RID: 23383
		private static readonly IntPtr NativeFieldInfoPtr_TopLidContainer;

		// Token: 0x04005B58 RID: 23384
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidContainer;

		// Token: 0x04005B59 RID: 23385
		private static readonly IntPtr NativeFieldInfoPtr_PupilContainer;

		// Token: 0x04005B5A RID: 23386
		private static readonly IntPtr NativeFieldInfoPtr_TopLidRend;

		// Token: 0x04005B5B RID: 23387
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidRend;

		// Token: 0x04005B5C RID: 23388
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallRend;

		// Token: 0x04005B5D RID: 23389
		private static readonly IntPtr NativeFieldInfoPtr_EyeLookOrigin;

		// Token: 0x04005B5E RID: 23390
		private static readonly IntPtr NativeFieldInfoPtr_EyeLight;

		// Token: 0x04005B5F RID: 23391
		private static readonly IntPtr NativeFieldInfoPtr_PupilRend;

		// Token: 0x04005B60 RID: 23392
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005B61 RID: 23393
		private static readonly IntPtr NativeFieldInfoPtr_stateRoutine;

		// Token: 0x04005B62 RID: 23394
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005B63 RID: 23395
		private static readonly IntPtr NativeFieldInfoPtr_defaultEyeColor;

		// Token: 0x04005B64 RID: 23396
		private static readonly IntPtr NativeFieldInfoPtr_AngleOffset;

		// Token: 0x04005B65 RID: 23397
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0;

		// Token: 0x04005B66 RID: 23398
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0;

		// Token: 0x04005B67 RID: 23399
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0;

		// Token: 0x04005B68 RID: 23400
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005B69 RID: 23401
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_0;

		// Token: 0x04005B6A RID: 23402
		private static readonly IntPtr NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0;

		// Token: 0x04005B6B RID: 23403
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0;

		// Token: 0x04005B6C RID: 23404
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005B6D RID: 23405
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0;

		// Token: 0x04005B6E RID: 23406
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0;

		// Token: 0x04005B6F RID: 23407
		private static readonly IntPtr NativeMethodInfoPtr_SetDilation_Public_Void_Single_0;

		// Token: 0x04005B70 RID: 23408
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0;

		// Token: 0x04005B71 RID: 23409
		private static readonly IntPtr NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0;

		// Token: 0x04005B72 RID: 23410
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005B73 RID: 23411
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005B74 RID: 23412
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005B75 RID: 23413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEE RID: 2798
		[Serializable]
		[StructLayout(2)]
		public struct EyeLidConfiguration
		{
			// Token: 0x0600D58B RID: 54667 RVA: 0x0032E340 File Offset: 0x0032C540
			// Note: this type is marked as 'beforefieldinit'.
			static EyeLidConfiguration()
			{
				Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLidConfiguration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr);
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_topLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "topLidOpen");
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_bottomLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "bottomLidOpen");
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680068);
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680069);
			}

			// Token: 0x0600D58C RID: 54668 RVA: 0x0032E3BC File Offset: 0x0032C5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250467, XrefRangeEnd = 250474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D58D RID: 54669 RVA: 0x0032E3E8 File Offset: 0x0032C5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250474, XrefRangeEnd = 250476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D58E RID: 54670 RVA: 0x00067E3C File Offset: 0x0006603C
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, ref this));
			}

			// Token: 0x04008FA2 RID: 36770
			private static readonly IntPtr NativeFieldInfoPtr_topLidOpen;

			// Token: 0x04008FA3 RID: 36771
			private static readonly IntPtr NativeFieldInfoPtr_bottomLidOpen;

			// Token: 0x04008FA4 RID: 36772
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04008FA5 RID: 36773
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0;

			// Token: 0x04008FA6 RID: 36774
			[FieldOffset(0)]
			public float topLidOpen;

			// Token: 0x04008FA7 RID: 36775
			[FieldOffset(4)]
			public float bottomLidOpen;
		}

		// Token: 0x02000AEF RID: 2799
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D58F RID: 54671 RVA: 0x0032E444 File Offset: 0x0032C644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr);
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "startConfig");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "config");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "time");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680070);
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680071);
			}

			// Token: 0x0600D590 RID: 54672 RVA: 0x0032E4E8 File Offset: 0x0032C6E8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D591 RID: 54673 RVA: 0x0032E524 File Offset: 0x0032C724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250491, XrefRangeEnd = 250496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D592 RID: 54674 RVA: 0x00067E4E File Offset: 0x0006604E
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422C RID: 16940
			// (get) Token: 0x0600D593 RID: 54675 RVA: 0x0032E564 File Offset: 0x0032C764
			// (set) Token: 0x0600D594 RID: 54676 RVA: 0x00067E57 File Offset: 0x00066057
			public unsafe Eye.EyeLidConfiguration startConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig)) = value;
				}
			}

			// Token: 0x1700422D RID: 16941
			// (get) Token: 0x0600D595 RID: 54677 RVA: 0x0032E58C File Offset: 0x0032C78C
			// (set) Token: 0x0600D596 RID: 54678 RVA: 0x00067E72 File Offset: 0x00066072
			public unsafe Eye.EyeLidConfiguration config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config)) = value;
				}
			}

			// Token: 0x1700422E RID: 16942
			// (get) Token: 0x0600D597 RID: 54679 RVA: 0x0032E5B4 File Offset: 0x0032C7B4
			// (set) Token: 0x0600D598 RID: 54680 RVA: 0x00067E8D File Offset: 0x0006608D
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x1700422F RID: 16943
			// (get) Token: 0x0600D599 RID: 54681 RVA: 0x0032E5DC File Offset: 0x0032C7DC
			// (set) Token: 0x0600D59A RID: 54682 RVA: 0x00067EA8 File Offset: 0x000660A8
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FA8 RID: 36776
			private static readonly IntPtr NativeFieldInfoPtr_startConfig;

			// Token: 0x04008FA9 RID: 36777
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04008FAA RID: 36778
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008FAB RID: 36779
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FAC RID: 36780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FAD RID: 36781
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C65 RID: 3173
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0+<<SetEyeLidState>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E45B RID: 58459 RVA: 0x00358C90 File Offset: 0x00356E90
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<<SetEyeLidState>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680072);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680073);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680074);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680075);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680076);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680077);
				}

				// Token: 0x0600E45C RID: 58460 RVA: 0x00358D84 File Offset: 0x00356F84
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E45D RID: 58461 RVA: 0x00358DCC File Offset: 0x00356FCC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E45E RID: 58462 RVA: 0x00358E00 File Offset: 0x00357000
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250476, XrefRangeEnd = 250486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046EF RID: 18159
				// (get) Token: 0x0600E45F RID: 58463 RVA: 0x00358E3C File Offset: 0x0035703C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E460 RID: 58464 RVA: 0x00358E7C File Offset: 0x0035707C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250486, XrefRangeEnd = 250491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046F0 RID: 18160
				// (get) Token: 0x0600E461 RID: 58465 RVA: 0x00358EB0 File Offset: 0x003570B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E462 RID: 58466 RVA: 0x0006F54F File Offset: 0x0006D74F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046EB RID: 18155
				// (get) Token: 0x0600E463 RID: 58467 RVA: 0x00358EF0 File Offset: 0x003570F0
				// (set) Token: 0x0600E464 RID: 58468 RVA: 0x0006F558 File Offset: 0x0006D758
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046EC RID: 18156
				// (get) Token: 0x0600E465 RID: 58469 RVA: 0x00358F18 File Offset: 0x00357118
				// (set) Token: 0x0600E466 RID: 58470 RVA: 0x0006F573 File Offset: 0x0006D773
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046ED RID: 18157
				// (get) Token: 0x0600E467 RID: 58471 RVA: 0x00358F48 File Offset: 0x00357148
				// (set) Token: 0x0600E468 RID: 58472 RVA: 0x0006F592 File Offset: 0x0006D792
				public unsafe Eye.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046EE RID: 18158
				// (get) Token: 0x0600E469 RID: 58473 RVA: 0x00358F78 File Offset: 0x00357178
				// (set) Token: 0x0600E46A RID: 58474 RVA: 0x0006F5B1 File Offset: 0x0006D7B1
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x040098C1 RID: 39105
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098C2 RID: 39106
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098C3 RID: 39107
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098C4 RID: 39108
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040098C5 RID: 39109
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098C6 RID: 39110
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098C7 RID: 39111
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098C8 RID: 39112
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098C9 RID: 39113
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098CA RID: 39114
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AF0 RID: 2800
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D59B RID: 54683 RVA: 0x0032E60C File Offset: 0x0032C80C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr);
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "blinkDuration");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "debug");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "endState");
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680078);
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680079);
			}

			// Token: 0x0600D59C RID: 54684 RVA: 0x0032E6B0 File Offset: 0x0032C8B0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D59D RID: 54685 RVA: 0x0032E6EC File Offset: 0x0032C8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250512, XrefRangeEnd = 250517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D59E RID: 54686 RVA: 0x00067EC7 File Offset: 0x000660C7
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004230 RID: 16944
			// (get) Token: 0x0600D59F RID: 54687 RVA: 0x0032E72C File Offset: 0x0032C92C
			// (set) Token: 0x0600D5A0 RID: 54688 RVA: 0x00067ED0 File Offset: 0x000660D0
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004231 RID: 16945
			// (get) Token: 0x0600D5A1 RID: 54689 RVA: 0x0032E75C File Offset: 0x0032C95C
			// (set) Token: 0x0600D5A2 RID: 54690 RVA: 0x00067EEF File Offset: 0x000660EF
			public unsafe float blinkDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration)) = value;
				}
			}

			// Token: 0x17004232 RID: 16946
			// (get) Token: 0x0600D5A3 RID: 54691 RVA: 0x0032E784 File Offset: 0x0032C984
			// (set) Token: 0x0600D5A4 RID: 54692 RVA: 0x00067F0A File Offset: 0x0006610A
			public unsafe bool debug
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug)) = value;
				}
			}

			// Token: 0x17004233 RID: 16947
			// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x0032E7AC File Offset: 0x0032C9AC
			// (set) Token: 0x0600D5A6 RID: 54694 RVA: 0x00067F25 File Offset: 0x00066125
			public unsafe Eye.EyeLidConfiguration endState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState)) = value;
				}
			}

			// Token: 0x04008FAE RID: 36782
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FAF RID: 36783
			private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

			// Token: 0x04008FB0 RID: 36784
			private static readonly IntPtr NativeFieldInfoPtr_debug;

			// Token: 0x04008FB1 RID: 36785
			private static readonly IntPtr NativeFieldInfoPtr_endState;

			// Token: 0x04008FB2 RID: 36786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FB3 RID: 36787
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C66 RID: 3174
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0+<<Blink>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E46B RID: 58475 RVA: 0x00358FA0 File Offset: 0x003571A0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<<Blink>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<start>5__2");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<end>5__3");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<holdTime>5__4");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<duration>5__5");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<i>5__6");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680080);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680081);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680082);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680083);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680084);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680085);
				}

				// Token: 0x0600E46C RID: 58476 RVA: 0x003590E4 File Offset: 0x003572E4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E46D RID: 58477 RVA: 0x0035912C File Offset: 0x0035732C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E46E RID: 58478 RVA: 0x00359160 File Offset: 0x00357360
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250496, XrefRangeEnd = 250507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046F9 RID: 18169
				// (get) Token: 0x0600E46F RID: 58479 RVA: 0x0035919C File Offset: 0x0035739C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E470 RID: 58480 RVA: 0x003591DC File Offset: 0x003573DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250507, XrefRangeEnd = 250512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046FA RID: 18170
				// (get) Token: 0x0600E471 RID: 58481 RVA: 0x00359210 File Offset: 0x00357410
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E472 RID: 58482 RVA: 0x0006F5CC File Offset: 0x0006D7CC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046F1 RID: 18161
				// (get) Token: 0x0600E473 RID: 58483 RVA: 0x00359250 File Offset: 0x00357450
				// (set) Token: 0x0600E474 RID: 58484 RVA: 0x0006F5D5 File Offset: 0x0006D7D5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046F2 RID: 18162
				// (get) Token: 0x0600E475 RID: 58485 RVA: 0x00359278 File Offset: 0x00357478
				// (set) Token: 0x0600E476 RID: 58486 RVA: 0x0006F5F0 File Offset: 0x0006D7F0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046F3 RID: 18163
				// (get) Token: 0x0600E477 RID: 58487 RVA: 0x003592A8 File Offset: 0x003574A8
				// (set) Token: 0x0600E478 RID: 58488 RVA: 0x0006F60F File Offset: 0x0006D80F
				public unsafe Eye.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046F4 RID: 18164
				// (get) Token: 0x0600E479 RID: 58489 RVA: 0x003592D8 File Offset: 0x003574D8
				// (set) Token: 0x0600E47A RID: 58490 RVA: 0x0006F62E File Offset: 0x0006D82E
				public unsafe Eye.EyeLidConfiguration _start_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2)) = value;
					}
				}

				// Token: 0x170046F5 RID: 18165
				// (get) Token: 0x0600E47B RID: 58491 RVA: 0x00359300 File Offset: 0x00357500
				// (set) Token: 0x0600E47C RID: 58492 RVA: 0x0006F649 File Offset: 0x0006D849
				public unsafe Eye.EyeLidConfiguration _end_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3)) = value;
					}
				}

				// Token: 0x170046F6 RID: 18166
				// (get) Token: 0x0600E47D RID: 58493 RVA: 0x00359328 File Offset: 0x00357528
				// (set) Token: 0x0600E47E RID: 58494 RVA: 0x0006F664 File Offset: 0x0006D864
				public unsafe float _holdTime_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4)) = value;
					}
				}

				// Token: 0x170046F7 RID: 18167
				// (get) Token: 0x0600E47F RID: 58495 RVA: 0x00359350 File Offset: 0x00357550
				// (set) Token: 0x0600E480 RID: 58496 RVA: 0x0006F67F File Offset: 0x0006D87F
				public unsafe float _duration_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5)) = value;
					}
				}

				// Token: 0x170046F8 RID: 18168
				// (get) Token: 0x0600E481 RID: 58497 RVA: 0x00359378 File Offset: 0x00357578
				// (set) Token: 0x0600E482 RID: 58498 RVA: 0x0006F69A File Offset: 0x0006D89A
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x040098CB RID: 39115
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098CC RID: 39116
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098CD RID: 39117
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098CE RID: 39118
				private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

				// Token: 0x040098CF RID: 39119
				private static readonly IntPtr NativeFieldInfoPtr__end_5__3;

				// Token: 0x040098D0 RID: 39120
				private static readonly IntPtr NativeFieldInfoPtr__holdTime_5__4;

				// Token: 0x040098D1 RID: 39121
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__5;

				// Token: 0x040098D2 RID: 39122
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x040098D3 RID: 39123
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098D4 RID: 39124
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098D5 RID: 39125
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098D6 RID: 39126
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098D7 RID: 39127
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098D8 RID: 39128
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
