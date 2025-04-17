using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000517 RID: 1303
	public class PowerLine : Constructable
	{
		// Token: 0x060073FE RID: 29694 RVA: 0x001FA09C File Offset: 0x001F829C
		// Note: this type is marked as 'beforefieldinit'.
		static PowerLine()
		{
			Il2CppClassPointerStore<PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerLine>.NativeClassPtr);
			PowerLine.NativeFieldInfoPtr_powerLine_MinSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MinSegments");
			PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MaxSegments");
			PowerLine.NativeFieldInfoPtr_maxLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "maxLineLength");
			PowerLine.NativeFieldInfoPtr_updateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "updateThreshold");
			PowerLine.NativeFieldInfoPtr_nodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA");
			PowerLine.NativeFieldInfoPtr_nodeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB");
			PowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "LengthFactor");
			PowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "segments");
			PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677886);
			PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677887);
			PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677888);
			PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677889);
			PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677890);
			PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677891);
			PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677892);
			PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677893);
			PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677894);
			PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677895);
			PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677896);
			PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677897);
			PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677898);
			PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677899);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677901);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677902);
			PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677903);
			PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677904);
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x001FA324 File Offset: 0x001F8524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226750, RefRangeEnd = 226751, XrefRangeStart = 226711, XrefRangeEnd = 226750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePowerLine(PowerNode a, PowerNode b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x001FA378 File Offset: 0x001F8578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226751, XrefRangeEnd = 226773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x001FA3C4 File Offset: 0x001F85C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226773, XrefRangeEnd = 226815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x001FA400 File Offset: 0x001F8600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226866, RefRangeEnd = 226869, XrefRangeStart = 226815, XrefRangeEnd = 226866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x001FA434 File Offset: 0x001F8634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226889, RefRangeEnd = 226890, XrefRangeStart = 226869, XrefRangeEnd = 226889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshBoundingBox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x001FA468 File Offset: 0x001F8668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226897, RefRangeEnd = 226899, XrefRangeStart = 226890, XrefRangeEnd = 226897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetOtherNode(PowerNode firstNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x001FA4B8 File Offset: 0x001F86B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226906, RefRangeEnd = 226908, XrefRangeStart = 226899, XrefRangeEnd = 226906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x001FA4F8 File Offset: 0x001F86F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226908, XrefRangeEnd = 226912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x001FA540 File Offset: 0x001F8740
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 226949, RefRangeEnd = 226956, XrefRangeStart = 226912, XrefRangeEnd = 226949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanNodesBeConnected(PowerNode nodeA, PowerNode nodeB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x001FA594 File Offset: 0x001F8794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226966, RefRangeEnd = 226968, XrefRangeStart = 226956, XrefRangeEnd = 226966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x001FA5E0 File Offset: 0x001F87E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 226975, RefRangeEnd = 226979, XrefRangeStart = 226968, XrefRangeEnd = 226975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x001FA640 File Offset: 0x001F8840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227017, RefRangeEnd = 227020, XrefRangeStart = 226979, XrefRangeEnd = 227017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x001FA688 File Offset: 0x001F8888
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227093, RefRangeEnd = 227096, XrefRangeStart = 227020, XrefRangeEnd = 227093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x001FA6F4 File Offset: 0x001F88F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227096, XrefRangeEnd = 227108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x001FA730 File Offset: 0x001F8930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227108, XrefRangeEnd = 227109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x001FA76C File Offset: 0x001F896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227109, XrefRangeEnd = 227110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x001FA7A8 File Offset: 0x001F89A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x001FA7E4 File Offset: 0x001F89E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227110, XrefRangeEnd = 227111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x0003719E File Offset: 0x0003539E
		public PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x001FA820 File Offset: 0x001F8A20
		// (set) Token: 0x06007413 RID: 29715 RVA: 0x000371A7 File Offset: 0x000353A7
		public unsafe static int powerLine_MinSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&value));
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x001FA83C File Offset: 0x001F8A3C
		// (set) Token: 0x06007415 RID: 29717 RVA: 0x000371B5 File Offset: 0x000353B5
		public unsafe static int powerLine_MaxSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&value));
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x001FA858 File Offset: 0x001F8A58
		// (set) Token: 0x06007417 RID: 29719 RVA: 0x000371C3 File Offset: 0x000353C3
		public unsafe static float maxLineLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&value));
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x001FA874 File Offset: 0x001F8A74
		// (set) Token: 0x06007419 RID: 29721 RVA: 0x000371D1 File Offset: 0x000353D1
		public unsafe static float updateThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x001FA890 File Offset: 0x001F8A90
		// (set) Token: 0x0600741B RID: 29723 RVA: 0x000371DF File Offset: 0x000353DF
		public unsafe PowerNode nodeA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x001FA8C0 File Offset: 0x001F8AC0
		// (set) Token: 0x0600741D RID: 29725 RVA: 0x000371FE File Offset: 0x000353FE
		public unsafe PowerNode nodeB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x001FA8F0 File Offset: 0x001F8AF0
		// (set) Token: 0x0600741F RID: 29727 RVA: 0x0003721D File Offset: 0x0003541D
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x001FA918 File Offset: 0x001F8B18
		// (set) Token: 0x06007421 RID: 29729 RVA: 0x00037238 File Offset: 0x00035438
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x001FA948 File Offset: 0x001F8B48
		// (set) Token: 0x06007423 RID: 29731 RVA: 0x00037257 File Offset: 0x00035457
		public unsafe Vector3 nodeA_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos)) = value;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x001FA970 File Offset: 0x001F8B70
		// (set) Token: 0x06007425 RID: 29733 RVA: 0x00037272 File Offset: 0x00035472
		public unsafe Vector3 nodeB_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos)) = value;
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x001FA998 File Offset: 0x001F8B98
		// (set) Token: 0x06007427 RID: 29735 RVA: 0x0003728D File Offset: 0x0003548D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06007428 RID: 29736 RVA: 0x001FA9C0 File Offset: 0x001F8BC0
		// (set) Token: 0x06007429 RID: 29737 RVA: 0x000372A8 File Offset: 0x000354A8
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F36 RID: 20278
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MinSegments;

		// Token: 0x04004F37 RID: 20279
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MaxSegments;

		// Token: 0x04004F38 RID: 20280
		private static readonly IntPtr NativeFieldInfoPtr_maxLineLength;

		// Token: 0x04004F39 RID: 20281
		private static readonly IntPtr NativeFieldInfoPtr_updateThreshold;

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeFieldInfoPtr_nodeA;

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeFieldInfoPtr_nodeB;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04004F3D RID: 20285
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x04004F3E RID: 20286
		private static readonly IntPtr NativeFieldInfoPtr_nodeA_LastUpdatePos;

		// Token: 0x04004F3F RID: 20287
		private static readonly IntPtr NativeFieldInfoPtr_nodeB_LastUpdatePos;

		// Token: 0x04004F40 RID: 20288
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F41 RID: 20289
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F42 RID: 20290
		private static readonly IntPtr NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0;

		// Token: 0x04004F43 RID: 20291
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004F44 RID: 20292
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004F45 RID: 20293
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x04004F46 RID: 20294
		private static readonly IntPtr NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0;

		// Token: 0x04004F47 RID: 20295
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0;

		// Token: 0x04004F48 RID: 20296
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004F49 RID: 20297
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0;

		// Token: 0x04004F4A RID: 20298
		private static readonly IntPtr NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0;

		// Token: 0x04004F4B RID: 20299
		private static readonly IntPtr NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0;

		// Token: 0x04004F4C RID: 20300
		private static readonly IntPtr NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0;

		// Token: 0x04004F4D RID: 20301
		private static readonly IntPtr NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0;

		// Token: 0x04004F4E RID: 20302
		private static readonly IntPtr NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0;

		// Token: 0x04004F4F RID: 20303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F50 RID: 20304
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F51 RID: 20305
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F52 RID: 20306
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F53 RID: 20307
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
