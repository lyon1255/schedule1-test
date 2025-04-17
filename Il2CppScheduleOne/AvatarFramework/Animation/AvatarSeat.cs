using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060D RID: 1549
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x06008923 RID: 35107 RVA: 0x002408E4 File Offset: 0x0023EAE4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeat()
		{
			Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr);
			AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "<Occupant>k__BackingField");
			AvatarSeat.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "SittingPoint");
			AvatarSeat.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "AccessPoint");
			AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680366);
			AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680367);
			AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680368);
			AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680369);
			AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680370);
			AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680371);
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06008924 RID: 35108 RVA: 0x002409C8 File Offset: 0x0023EBC8
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253044, XrefRangeEnd = 253048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x00240A04 File Offset: 0x0023EC04
		// (set) Token: 0x06008926 RID: 35110 RVA: 0x00240A44 File Offset: 0x0023EC44
		public unsafe NPC Occupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00240A88 File Offset: 0x0023EC88
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x00240ABC File Offset: 0x0023ECBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253063, RefRangeEnd = 253066, XrefRangeStart = 253048, XrefRangeEnd = 253063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00240B00 File Offset: 0x0023ED00
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x000417E2 File Offset: 0x0003F9E2
		public AvatarSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600892B RID: 35115 RVA: 0x00240B3C File Offset: 0x0023ED3C
		// (set) Token: 0x0600892C RID: 35116 RVA: 0x000417EB File Offset: 0x0003F9EB
		public unsafe NPC _Occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x00240B6C File Offset: 0x0023ED6C
		// (set) Token: 0x0600892E RID: 35118 RVA: 0x0004180A File Offset: 0x0003FA0A
		public unsafe Transform SittingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x00240B9C File Offset: 0x0023ED9C
		// (set) Token: 0x06008930 RID: 35120 RVA: 0x00041829 File Offset: 0x0003FA29
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D23 RID: 23843
		private static readonly IntPtr NativeFieldInfoPtr__Occupant_k__BackingField;

		// Token: 0x04005D24 RID: 23844
		private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

		// Token: 0x04005D25 RID: 23845
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04005D26 RID: 23846
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04005D27 RID: 23847
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0;

		// Token: 0x04005D28 RID: 23848
		private static readonly IntPtr NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0;

		// Token: 0x04005D29 RID: 23849
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D2A RID: 23850
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0;

		// Token: 0x04005D2B RID: 23851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
