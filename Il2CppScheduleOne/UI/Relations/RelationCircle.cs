using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Relations
{
	// Token: 0x02000699 RID: 1689
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x06009632 RID: 38450 RVA: 0x00267AD0 File Offset: 0x00265CD0
		// Note: this type is marked as 'beforefieldinit'.
		static RelationCircle()
		{
			Il2CppClassPointerStore<RelationCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Relations", "RelationCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr);
			RelationCircle.NativeFieldInfoPtr_NotchMinRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMinRot");
			RelationCircle.NativeFieldInfoPtr_NotchMaxRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMaxRot");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_ZeroDependence");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_MaxDependence");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC_ID");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC");
			RelationCircle.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onClicked");
			RelationCircle.NativeFieldInfoPtr_onHoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverStart");
			RelationCircle.NativeFieldInfoPtr_onHoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverEnd");
			RelationCircle.NativeFieldInfoPtr_AutoSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AutoSetName");
			RelationCircle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Rect");
			RelationCircle.NativeFieldInfoPtr_PortraitBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitBackground");
			RelationCircle.NativeFieldInfoPtr_HeadshotImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "HeadshotImg");
			RelationCircle.NativeFieldInfoPtr_NotchPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchPivot");
			RelationCircle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Locked");
			RelationCircle.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Button");
			RelationCircle.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Trigger");
			RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681868);
			RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681869);
			RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681870);
			RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681871);
			RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681872);
			RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681873);
			RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681874);
			RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681875);
			RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681876);
			RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681877);
			RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681878);
			RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681879);
			RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681880);
			RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681881);
			RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681882);
			RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681883);
			RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681884);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681886);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681887);
			RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681888);
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x00267DE4 File Offset: 0x00265FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269286, XrefRangeEnd = 269348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x00267E18 File Offset: 0x00266018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269348, XrefRangeEnd = 269359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x00267E4C File Offset: 0x0026604C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269440, RefRangeEnd = 269442, XrefRangeStart = 269359, XrefRangeEnd = 269440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x00267E90 File Offset: 0x00266090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269472, RefRangeEnd = 269473, XrefRangeStart = 269442, XrefRangeEnd = 269472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x00267EC4 File Offset: 0x002660C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269473, XrefRangeEnd = 269474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x00267F04 File Offset: 0x00266104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269477, RefRangeEnd = 269480, XrefRangeStart = 269474, XrefRangeEnd = 269477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotchPosition(float relationshipDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationshipDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x00267F44 File Offset: 0x00266144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269483, RefRangeEnd = 269485, XrefRangeStart = 269480, XrefRangeEnd = 269483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotchPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x00267F78 File Offset: 0x00266178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269498, RefRangeEnd = 269499, XrefRangeStart = 269485, XrefRangeEnd = 269498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDependenceDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x00267FAC File Offset: 0x002661AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269499, XrefRangeEnd = 269504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x00267FE0 File Offset: 0x002661E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269508, RefRangeEnd = 269509, XrefRangeStart = 269504, XrefRangeEnd = 269508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x0026802C File Offset: 0x0026622C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269514, RefRangeEnd = 269515, XrefRangeStart = 269509, XrefRangeEnd = 269514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x00268060 File Offset: 0x00266260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269530, RefRangeEnd = 269532, XrefRangeStart = 269515, XrefRangeEnd = 269530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlackout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x00268094 File Offset: 0x00266294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269532, XrefRangeEnd = 269533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackedOut(bool blackedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blackedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x002680D4 File Offset: 0x002662D4
		[CallerCount(0)]
		public unsafe void ButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x00268108 File Offset: 0x00266308
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0026813C File Offset: 0x0026633C
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x00268170 File Offset: 0x00266370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269533, XrefRangeEnd = 269537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x002681AC File Offset: 0x002663AC
		[CallerCount(0)]
		public unsafe void _Awake_b__17_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x002681F0 File Offset: 0x002663F0
		[CallerCount(0)]
		public unsafe void _Awake_b__17_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x00268234 File Offset: 0x00266434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269537, XrefRangeEnd = 269538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AssignNPC_b__19_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x00048E38 File Offset: 0x00047038
		public RelationCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x06009648 RID: 38472 RVA: 0x00268280 File Offset: 0x00266480
		// (set) Token: 0x06009649 RID: 38473 RVA: 0x00048E41 File Offset: 0x00047041
		public unsafe static float NotchMinRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&value));
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600964A RID: 38474 RVA: 0x0026829C File Offset: 0x0026649C
		// (set) Token: 0x0600964B RID: 38475 RVA: 0x00048E4F File Offset: 0x0004704F
		public unsafe static float NotchMaxRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&value));
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x002682B8 File Offset: 0x002664B8
		// (set) Token: 0x0600964D RID: 38477 RVA: 0x00048E5D File Offset: 0x0004705D
		public unsafe static Color PortraitColor_ZeroDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600964E RID: 38478 RVA: 0x002682D4 File Offset: 0x002664D4
		// (set) Token: 0x0600964F RID: 38479 RVA: 0x00048E6B File Offset: 0x0004706B
		public unsafe static Color PortraitColor_MaxDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x06009650 RID: 38480 RVA: 0x002682F0 File Offset: 0x002664F0
		// (set) Token: 0x06009651 RID: 38481 RVA: 0x00048E79 File Offset: 0x00047079
		public unsafe string AssignedNPC_ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x06009652 RID: 38482 RVA: 0x00268318 File Offset: 0x00266518
		// (set) Token: 0x06009653 RID: 38483 RVA: 0x00048E98 File Offset: 0x00047098
		public unsafe NPC AssignedNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x06009654 RID: 38484 RVA: 0x00268348 File Offset: 0x00266548
		// (set) Token: 0x06009655 RID: 38485 RVA: 0x00048EB7 File Offset: 0x000470B7
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x00268378 File Offset: 0x00266578
		// (set) Token: 0x06009657 RID: 38487 RVA: 0x00048ED6 File Offset: 0x000470D6
		public unsafe Action onHoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x06009658 RID: 38488 RVA: 0x002683A8 File Offset: 0x002665A8
		// (set) Token: 0x06009659 RID: 38489 RVA: 0x00048EF5 File Offset: 0x000470F5
		public unsafe Action onHoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600965A RID: 38490 RVA: 0x002683D8 File Offset: 0x002665D8
		// (set) Token: 0x0600965B RID: 38491 RVA: 0x00048F14 File Offset: 0x00047114
		public unsafe bool AutoSetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName)) = value;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600965C RID: 38492 RVA: 0x00268400 File Offset: 0x00266600
		// (set) Token: 0x0600965D RID: 38493 RVA: 0x00048F2F File Offset: 0x0004712F
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x00268430 File Offset: 0x00266630
		// (set) Token: 0x0600965F RID: 38495 RVA: 0x00048F4E File Offset: 0x0004714E
		public unsafe Image PortraitBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x00268460 File Offset: 0x00266660
		// (set) Token: 0x06009661 RID: 38497 RVA: 0x00048F6D File Offset: 0x0004716D
		public unsafe Image HeadshotImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x00268490 File Offset: 0x00266690
		// (set) Token: 0x06009663 RID: 38499 RVA: 0x00048F8C File Offset: 0x0004718C
		public unsafe RectTransform NotchPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x002684C0 File Offset: 0x002666C0
		// (set) Token: 0x06009665 RID: 38501 RVA: 0x00048FAB File Offset: 0x000471AB
		public unsafe RectTransform Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x002684F0 File Offset: 0x002666F0
		// (set) Token: 0x06009667 RID: 38503 RVA: 0x00048FCA File Offset: 0x000471CA
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x06009668 RID: 38504 RVA: 0x00268520 File Offset: 0x00266720
		// (set) Token: 0x06009669 RID: 38505 RVA: 0x00048FE9 File Offset: 0x000471E9
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006540 RID: 25920
		private static readonly IntPtr NativeFieldInfoPtr_NotchMinRot;

		// Token: 0x04006541 RID: 25921
		private static readonly IntPtr NativeFieldInfoPtr_NotchMaxRot;

		// Token: 0x04006542 RID: 25922
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_ZeroDependence;

		// Token: 0x04006543 RID: 25923
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_MaxDependence;

		// Token: 0x04006544 RID: 25924
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPC_ID;

		// Token: 0x04006545 RID: 25925
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPC;

		// Token: 0x04006546 RID: 25926
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04006547 RID: 25927
		private static readonly IntPtr NativeFieldInfoPtr_onHoverStart;

		// Token: 0x04006548 RID: 25928
		private static readonly IntPtr NativeFieldInfoPtr_onHoverEnd;

		// Token: 0x04006549 RID: 25929
		private static readonly IntPtr NativeFieldInfoPtr_AutoSetName;

		// Token: 0x0400654A RID: 25930
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x0400654B RID: 25931
		private static readonly IntPtr NativeFieldInfoPtr_PortraitBackground;

		// Token: 0x0400654C RID: 25932
		private static readonly IntPtr NativeFieldInfoPtr_HeadshotImg;

		// Token: 0x0400654D RID: 25933
		private static readonly IntPtr NativeFieldInfoPtr_NotchPivot;

		// Token: 0x0400654E RID: 25934
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x0400654F RID: 25935
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04006550 RID: 25936
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04006551 RID: 25937
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006552 RID: 25938
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006553 RID: 25939
		private static readonly IntPtr NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0;

		// Token: 0x04006554 RID: 25940
		private static readonly IntPtr NativeMethodInfoPtr_UnassignNPC_Private_Void_0;

		// Token: 0x04006555 RID: 25941
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0;

		// Token: 0x04006556 RID: 25942
		private static readonly IntPtr NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0;

		// Token: 0x04006557 RID: 25943
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0;

		// Token: 0x04006558 RID: 25944
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0;

		// Token: 0x04006559 RID: 25945
		private static readonly IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_0;

		// Token: 0x0400655A RID: 25946
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0;

		// Token: 0x0400655B RID: 25947
		private static readonly IntPtr NativeMethodInfoPtr_LoadNPCData_Public_Void_0;

		// Token: 0x0400655C RID: 25948
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlackout_Private_Void_0;

		// Token: 0x0400655D RID: 25949
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0;

		// Token: 0x0400655E RID: 25950
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

		// Token: 0x0400655F RID: 25951
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04006560 RID: 25952
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04006561 RID: 25953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006562 RID: 25954
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0;

		// Token: 0x04006563 RID: 25955
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0;

		// Token: 0x04006564 RID: 25956
		private static readonly IntPtr NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0;
	}
}
