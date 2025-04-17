using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035A RID: 858
	public class PatrolGroup : Il2CppSystem.Object
	{
		// Token: 0x060041ED RID: 16877 RVA: 0x00149CC4 File Offset: 0x00147EC4
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolGroup()
		{
			Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PatrolGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr);
			PatrolGroup.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Members");
			PatrolGroup.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Route");
			PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "CurrentWaypoint");
			PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671321);
			PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671322);
			PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671323);
			PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671324);
			PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671325);
			PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671326);
			PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671327);
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00149DBC File Offset: 0x00147FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151858, RefRangeEnd = 151859, XrefRangeStart = 151849, XrefRangeEnd = 151858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup(FootPatrolRoute route) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00149E08 File Offset: 0x00148008
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151894, RefRangeEnd = 151898, XrefRangeStart = 151859, XrefRangeEnd = 151894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDestination(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00149E58 File Offset: 0x00148058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151923, RefRangeEnd = 151925, XrefRangeStart = 151898, XrefRangeEnd = 151923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisbandGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00149E8C File Offset: 0x0014808C
		[CallerCount(0)]
		public unsafe void AdvanceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00149EC0 File Offset: 0x001480C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151925, XrefRangeEnd = 151936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMemberOffset(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00149F10 File Offset: 0x00148110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151936, XrefRangeEnd = 151944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00149F4C File Offset: 0x0014814C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151944, XrefRangeEnd = 151963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x0002062C File Offset: 0x0001E82C
		public PatrolGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00149F88 File Offset: 0x00148188
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x00020635 File Offset: 0x0001E835
		public unsafe List<NPC> Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x00149FB8 File Offset: 0x001481B8
		// (set) Token: 0x060041F9 RID: 16889 RVA: 0x00020654 File Offset: 0x0001E854
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x00149FE8 File Offset: 0x001481E8
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x00020673 File Offset: 0x0001E873
		public unsafe int CurrentWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeMethodInfoPtr_DisbandGroup_Public_Void_0;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceGroup_Public_Void_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Boolean_0;
	}
}
