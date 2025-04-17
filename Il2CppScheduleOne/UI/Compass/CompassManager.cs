using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Compass
{
	// Token: 0x020006F5 RID: 1781
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x06009F8E RID: 40846 RVA: 0x00283A8C File Offset: 0x00281C8C
		// Note: this type is marked as 'beforefieldinit'.
		static CompassManager()
		{
			Il2CppClassPointerStore<CompassManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Compass", "CompassManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager>.NativeClassPtr);
			CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DISTANCE_LABEL_THRESHOLD");
			CompassManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Container");
			CompassManager.NativeFieldInfoPtr_NotchPointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPointContainer");
			CompassManager.NativeFieldInfoPtr_NotchUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchUIContainer");
			CompassManager.NativeFieldInfoPtr_ElementUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementUIContainer");
			CompassManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Canvas");
			CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DirectionIndicatorPrefab");
			CompassManager.NativeFieldInfoPtr_NotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPrefab");
			CompassManager.NativeFieldInfoPtr_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementPrefab");
			CompassManager.NativeFieldInfoPtr_CompassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassEnabled");
			CompassManager.NativeFieldInfoPtr_ElementContentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementContentSize");
			CompassManager.NativeFieldInfoPtr_CompassUIRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassUIRange");
			CompassManager.NativeFieldInfoPtr_FullAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "FullAlphaRange");
			CompassManager.NativeFieldInfoPtr_AngleDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "AngleDivisor");
			CompassManager.NativeFieldInfoPtr_ClosedYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ClosedYPos");
			CompassManager.NativeFieldInfoPtr_OpenYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "OpenYPos");
			CompassManager.NativeFieldInfoPtr_notchPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notchPositions");
			CompassManager.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notches");
			CompassManager.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "elements");
			CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "lerpContainerPositionCoroutine");
			CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682825);
			CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682826);
			CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682827);
			CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682828);
			CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682829);
			CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682830);
			CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682831);
			CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682832);
			CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682833);
			CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682834);
			CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682835);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682836);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682837);
			CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682838);
			CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682839);
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x00283D78 File Offset: 0x00281F78
		public unsafe Transform cam
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 281348, RefRangeEnd = 281352, XrefRangeStart = 281342, XrefRangeEnd = 281348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x00283DB8 File Offset: 0x00281FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281352, XrefRangeEnd = 281413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x00283DF4 File Offset: 0x00281FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281413, XrefRangeEnd = 281423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x00283E28 File Offset: 0x00282028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281423, XrefRangeEnd = 281433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x00283E5C File Offset: 0x0028205C
		[CallerCount(0)]
		public unsafe void SetCompassEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x00283E9C File Offset: 0x0028209C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 281442, RefRangeEnd = 281475, XrefRangeStart = 281433, XrefRangeEnd = 281442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x00283EDC File Offset: 0x002820DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281493, RefRangeEnd = 281494, XrefRangeStart = 281475, XrefRangeEnd = 281493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNotches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00283F10 File Offset: 0x00282110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281528, RefRangeEnd = 281529, XrefRangeStart = 281494, XrefRangeEnd = 281528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00283F44 File Offset: 0x00282144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281558, RefRangeEnd = 281559, XrefRangeStart = 281529, XrefRangeEnd = 281558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElement(CompassManager.Element element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00283F88 File Offset: 0x00282188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281581, RefRangeEnd = 281584, XrefRangeStart = 281559, XrefRangeEnd = 281581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x00283FE4 File Offset: 0x002821E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281626, RefRangeEnd = 281628, XrefRangeStart = 281584, XrefRangeEnd = 281626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentPrefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr3) : null;
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x00284054 File Offset: 0x00282254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281628, XrefRangeEnd = 281640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x002840A4 File Offset: 0x002822A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281649, RefRangeEnd = 281650, XrefRangeStart = 281640, XrefRangeEnd = 281649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(el);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x002840F4 File Offset: 0x002822F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281650, XrefRangeEnd = 281674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x00284130 File Offset: 0x00282330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281674, XrefRangeEnd = 281679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Boolean_PDM_0(float yPos, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x0004E61F File Offset: 0x0004C81F
		public CompassManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06009F9F RID: 40863 RVA: 0x0028418C File Offset: 0x0028238C
		// (set) Token: 0x06009FA0 RID: 40864 RVA: 0x0004E628 File Offset: 0x0004C828
		public unsafe static float DISTANCE_LABEL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x002841A8 File Offset: 0x002823A8
		// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x0004E636 File Offset: 0x0004C836
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x002841D8 File Offset: 0x002823D8
		// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x0004E655 File Offset: 0x0004C855
		public unsafe Transform NotchPointContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x00284208 File Offset: 0x00282408
		// (set) Token: 0x06009FA6 RID: 40870 RVA: 0x0004E674 File Offset: 0x0004C874
		public unsafe RectTransform NotchUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06009FA7 RID: 40871 RVA: 0x00284238 File Offset: 0x00282438
		// (set) Token: 0x06009FA8 RID: 40872 RVA: 0x0004E693 File Offset: 0x0004C893
		public unsafe RectTransform ElementUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06009FA9 RID: 40873 RVA: 0x00284268 File Offset: 0x00282468
		// (set) Token: 0x06009FAA RID: 40874 RVA: 0x0004E6B2 File Offset: 0x0004C8B2
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x00284298 File Offset: 0x00282498
		// (set) Token: 0x06009FAC RID: 40876 RVA: 0x0004E6D1 File Offset: 0x0004C8D1
		public unsafe GameObject DirectionIndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06009FAD RID: 40877 RVA: 0x002842C8 File Offset: 0x002824C8
		// (set) Token: 0x06009FAE RID: 40878 RVA: 0x0004E6F0 File Offset: 0x0004C8F0
		public unsafe GameObject NotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06009FAF RID: 40879 RVA: 0x002842F8 File Offset: 0x002824F8
		// (set) Token: 0x06009FB0 RID: 40880 RVA: 0x0004E70F File Offset: 0x0004C90F
		public unsafe GameObject ElementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06009FB1 RID: 40881 RVA: 0x00284328 File Offset: 0x00282528
		// (set) Token: 0x06009FB2 RID: 40882 RVA: 0x0004E72E File Offset: 0x0004C92E
		public unsafe bool CompassEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled)) = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x00284350 File Offset: 0x00282550
		// (set) Token: 0x06009FB4 RID: 40884 RVA: 0x0004E749 File Offset: 0x0004C949
		public unsafe Vector2 ElementContentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize)) = value;
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x00284378 File Offset: 0x00282578
		// (set) Token: 0x06009FB6 RID: 40886 RVA: 0x0004E764 File Offset: 0x0004C964
		public unsafe float CompassUIRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange)) = value;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x002843A0 File Offset: 0x002825A0
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x0004E77F File Offset: 0x0004C97F
		public unsafe float FullAlphaRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange)) = value;
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x002843C8 File Offset: 0x002825C8
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x0004E79A File Offset: 0x0004C99A
		public unsafe float AngleDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor)) = value;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x002843F0 File Offset: 0x002825F0
		// (set) Token: 0x06009FBC RID: 40892 RVA: 0x0004E7B5 File Offset: 0x0004C9B5
		public unsafe float ClosedYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos)) = value;
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x00284418 File Offset: 0x00282618
		// (set) Token: 0x06009FBE RID: 40894 RVA: 0x0004E7D0 File Offset: 0x0004C9D0
		public unsafe float OpenYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos)) = value;
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x00284440 File Offset: 0x00282640
		// (set) Token: 0x06009FC0 RID: 40896 RVA: 0x0004E7EB File Offset: 0x0004C9EB
		public unsafe List<Transform> notchPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x00284470 File Offset: 0x00282670
		// (set) Token: 0x06009FC2 RID: 40898 RVA: 0x0004E80A File Offset: 0x0004CA0A
		public unsafe List<CompassManager.Notch> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Notch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x002844A0 File Offset: 0x002826A0
		// (set) Token: 0x06009FC4 RID: 40900 RVA: 0x0004E829 File Offset: 0x0004CA29
		public unsafe List<CompassManager.Element> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x002844D0 File Offset: 0x002826D0
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x0004E848 File Offset: 0x0004CA48
		public unsafe Coroutine lerpContainerPositionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B03 RID: 27395
		private static readonly IntPtr NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD;

		// Token: 0x04006B04 RID: 27396
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006B05 RID: 27397
		private static readonly IntPtr NativeFieldInfoPtr_NotchPointContainer;

		// Token: 0x04006B06 RID: 27398
		private static readonly IntPtr NativeFieldInfoPtr_NotchUIContainer;

		// Token: 0x04006B07 RID: 27399
		private static readonly IntPtr NativeFieldInfoPtr_ElementUIContainer;

		// Token: 0x04006B08 RID: 27400
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006B09 RID: 27401
		private static readonly IntPtr NativeFieldInfoPtr_DirectionIndicatorPrefab;

		// Token: 0x04006B0A RID: 27402
		private static readonly IntPtr NativeFieldInfoPtr_NotchPrefab;

		// Token: 0x04006B0B RID: 27403
		private static readonly IntPtr NativeFieldInfoPtr_ElementPrefab;

		// Token: 0x04006B0C RID: 27404
		private static readonly IntPtr NativeFieldInfoPtr_CompassEnabled;

		// Token: 0x04006B0D RID: 27405
		private static readonly IntPtr NativeFieldInfoPtr_ElementContentSize;

		// Token: 0x04006B0E RID: 27406
		private static readonly IntPtr NativeFieldInfoPtr_CompassUIRange;

		// Token: 0x04006B0F RID: 27407
		private static readonly IntPtr NativeFieldInfoPtr_FullAlphaRange;

		// Token: 0x04006B10 RID: 27408
		private static readonly IntPtr NativeFieldInfoPtr_AngleDivisor;

		// Token: 0x04006B11 RID: 27409
		private static readonly IntPtr NativeFieldInfoPtr_ClosedYPos;

		// Token: 0x04006B12 RID: 27410
		private static readonly IntPtr NativeFieldInfoPtr_OpenYPos;

		// Token: 0x04006B13 RID: 27411
		private static readonly IntPtr NativeFieldInfoPtr_notchPositions;

		// Token: 0x04006B14 RID: 27412
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04006B15 RID: 27413
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04006B16 RID: 27414
		private static readonly IntPtr NativeFieldInfoPtr_lerpContainerPositionCoroutine;

		// Token: 0x04006B17 RID: 27415
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04006B18 RID: 27416
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006B19 RID: 27417
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006B1A RID: 27418
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006B1B RID: 27419
		private static readonly IntPtr NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0;

		// Token: 0x04006B1C RID: 27420
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04006B1D RID: 27421
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNotches_Private_Void_0;

		// Token: 0x04006B1E RID: 27422
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04006B1F RID: 27423
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0;

		// Token: 0x04006B20 RID: 27424
		private static readonly IntPtr NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0;

		// Token: 0x04006B21 RID: 27425
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0;

		// Token: 0x04006B22 RID: 27426
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0;

		// Token: 0x04006B23 RID: 27427
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0;

		// Token: 0x04006B24 RID: 27428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006B25 RID: 27429
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0;

		// Token: 0x02000BA3 RID: 2979
		public class Notch : Il2CppSystem.Object
		{
			// Token: 0x0600DC7A RID: 56442 RVA: 0x00342034 File Offset: 0x00340234
			// Note: this type is marked as 'beforefieldinit'.
			static Notch()
			{
				Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Notch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr);
				CompassManager.Notch.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Rect");
				CompassManager.Notch.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Group");
				CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, 100682840);
			}

			// Token: 0x0600DC7B RID: 56443 RVA: 0x0034209C File Offset: 0x0034029C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Notch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7C RID: 56444 RVA: 0x0006B69C File Offset: 0x0006989C
			public Notch(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004454 RID: 17492
			// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x003420D8 File Offset: 0x003402D8
			// (set) Token: 0x0600DC7E RID: 56446 RVA: 0x0006B6A5 File Offset: 0x000698A5
			public unsafe RectTransform Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004455 RID: 17493
			// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x00342108 File Offset: 0x00340308
			// (set) Token: 0x0600DC80 RID: 56448 RVA: 0x0006B6C4 File Offset: 0x000698C4
			public unsafe CanvasGroup Group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093C9 RID: 37833
			private static readonly IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x040093CA RID: 37834
			private static readonly IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x040093CB RID: 37835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BA4 RID: 2980
		public class Element : Il2CppSystem.Object
		{
			// Token: 0x0600DC81 RID: 56449 RVA: 0x00342138 File Offset: 0x00340338
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr);
				CompassManager.Element.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Visible");
				CompassManager.Element.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Rect");
				CompassManager.Element.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Group");
				CompassManager.Element.NativeFieldInfoPtr_DistanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "DistanceLabel");
				CompassManager.Element.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Transform");
				CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100682841);
			}

			// Token: 0x0600DC82 RID: 56450 RVA: 0x003421DC File Offset: 0x003403DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC83 RID: 56451 RVA: 0x0006B6E3 File Offset: 0x000698E3
			public Element(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004456 RID: 17494
			// (get) Token: 0x0600DC84 RID: 56452 RVA: 0x00342218 File Offset: 0x00340418
			// (set) Token: 0x0600DC85 RID: 56453 RVA: 0x0006B6EC File Offset: 0x000698EC
			public unsafe bool Visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible)) = value;
				}
			}

			// Token: 0x17004457 RID: 17495
			// (get) Token: 0x0600DC86 RID: 56454 RVA: 0x00342240 File Offset: 0x00340440
			// (set) Token: 0x0600DC87 RID: 56455 RVA: 0x0006B707 File Offset: 0x00069907
			public unsafe RectTransform Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004458 RID: 17496
			// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x00342270 File Offset: 0x00340470
			// (set) Token: 0x0600DC89 RID: 56457 RVA: 0x0006B726 File Offset: 0x00069926
			public unsafe CanvasGroup Group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004459 RID: 17497
			// (get) Token: 0x0600DC8A RID: 56458 RVA: 0x003422A0 File Offset: 0x003404A0
			// (set) Token: 0x0600DC8B RID: 56459 RVA: 0x0006B745 File Offset: 0x00069945
			public unsafe TextMeshProUGUI DistanceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445A RID: 17498
			// (get) Token: 0x0600DC8C RID: 56460 RVA: 0x003422D0 File Offset: 0x003404D0
			// (set) Token: 0x0600DC8D RID: 56461 RVA: 0x0006B764 File Offset: 0x00069964
			public unsafe Transform Transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093CC RID: 37836
			private static readonly IntPtr NativeFieldInfoPtr_Visible;

			// Token: 0x040093CD RID: 37837
			private static readonly IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x040093CE RID: 37838
			private static readonly IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x040093CF RID: 37839
			private static readonly IntPtr NativeFieldInfoPtr_DistanceLabel;

			// Token: 0x040093D0 RID: 37840
			private static readonly IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x040093D1 RID: 37841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BA5 RID: 2981
		[ObfuscatedName("ScheduleOne.UI.Compass.CompassManager+<<SetVisible>g__LerpContainerPosition|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DC8E RID: 56462 RVA: 0x00342300 File Offset: 0x00340500
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique()
			{
				Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "<<SetVisible>g__LerpContainerPosition|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>1__state");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>2__current");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "visible");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>4__this");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "yPos");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<t>5__2");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<startPos>5__3");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<endPos>5__4");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682842);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682843);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682844);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682845);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682846);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682847);
			}

			// Token: 0x0600DC8F RID: 56463 RVA: 0x00342444 File Offset: 0x00340644
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC90 RID: 56464 RVA: 0x0034248C File Offset: 0x0034068C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC91 RID: 56465 RVA: 0x003424C0 File Offset: 0x003406C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281328, XrefRangeEnd = 281337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004463 RID: 17507
			// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x003424FC File Offset: 0x003406FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC93 RID: 56467 RVA: 0x0034253C File Offset: 0x0034073C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281337, XrefRangeEnd = 281342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004464 RID: 17508
			// (get) Token: 0x0600DC94 RID: 56468 RVA: 0x00342570 File Offset: 0x00340770
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC95 RID: 56469 RVA: 0x0006B783 File Offset: 0x00069983
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445B RID: 17499
			// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x003425B0 File Offset: 0x003407B0
			// (set) Token: 0x0600DC97 RID: 56471 RVA: 0x0006B78C File Offset: 0x0006998C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700445C RID: 17500
			// (get) Token: 0x0600DC98 RID: 56472 RVA: 0x003425D8 File Offset: 0x003407D8
			// (set) Token: 0x0600DC99 RID: 56473 RVA: 0x0006B7A7 File Offset: 0x000699A7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445D RID: 17501
			// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x00342608 File Offset: 0x00340808
			// (set) Token: 0x0600DC9B RID: 56475 RVA: 0x0006B7C6 File Offset: 0x000699C6
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x1700445E RID: 17502
			// (get) Token: 0x0600DC9C RID: 56476 RVA: 0x00342630 File Offset: 0x00340830
			// (set) Token: 0x0600DC9D RID: 56477 RVA: 0x0006B7E1 File Offset: 0x000699E1
			public unsafe CompassManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445F RID: 17503
			// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x00342660 File Offset: 0x00340860
			// (set) Token: 0x0600DC9F RID: 56479 RVA: 0x0006B800 File Offset: 0x00069A00
			public unsafe float yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x17004460 RID: 17504
			// (get) Token: 0x0600DCA0 RID: 56480 RVA: 0x00342688 File Offset: 0x00340888
			// (set) Token: 0x0600DCA1 RID: 56481 RVA: 0x0006B81B File Offset: 0x00069A1B
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x17004461 RID: 17505
			// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x003426B0 File Offset: 0x003408B0
			// (set) Token: 0x0600DCA3 RID: 56483 RVA: 0x0006B836 File Offset: 0x00069A36
			public unsafe Vector2 _startPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
				}
			}

			// Token: 0x17004462 RID: 17506
			// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x003426D8 File Offset: 0x003408D8
			// (set) Token: 0x0600DCA5 RID: 56485 RVA: 0x0006B851 File Offset: 0x00069A51
			public unsafe Vector2 _endPos_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
				}
			}

			// Token: 0x040093D2 RID: 37842
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093D3 RID: 37843
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093D4 RID: 37844
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x040093D5 RID: 37845
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093D6 RID: 37846
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x040093D7 RID: 37847
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040093D8 RID: 37848
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x040093D9 RID: 37849
			private static readonly IntPtr NativeFieldInfoPtr__endPos_5__4;

			// Token: 0x040093DA RID: 37850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093DB RID: 37851
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093DC RID: 37852
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093DD RID: 37853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093DE RID: 37854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093DF RID: 37855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
