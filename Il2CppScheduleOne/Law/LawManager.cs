using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D8 RID: 984
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x06004C23 RID: 19491 RVA: 0x0016ECC8 File Offset: 0x0016CEC8
		// Note: this type is marked as 'beforefieldinit'.
		static LawManager()
		{
			Il2CppClassPointerStore<LawManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager>.NativeClassPtr);
			LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_OFFICER_COUNT");
			LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_VEHICLE_USE_THRESHOLD");
			LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672718);
			LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672719);
			LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672720);
			LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672721);
			LawManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672722);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x0016ED84 File Offset: 0x0016CF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165261, XrefRangeEnd = 165287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x0016EDC0 File Offset: 0x0016CFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165307, RefRangeEnd = 165310, XrefRangeStart = 165287, XrefRangeEnd = 165307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceCalled(Player target, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x0016EE14 File Offset: 0x0016D014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165338, RefRangeEnd = 165339, XrefRangeStart = 165310, XrefRangeEnd = 165338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x0016EE74 File Offset: 0x0016D074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165339, XrefRangeEnd = 165351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x0016EEC4 File Offset: 0x0016D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165351, XrefRangeEnd = 165354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x000249B4 File Offset: 0x00022BB4
		public LawManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x0016EF00 File Offset: 0x0016D100
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x000249BD File Offset: 0x00022BBD
		public unsafe static int DISPATCH_OFFICER_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x0016EF1C File Offset: 0x0016D11C
		// (set) Token: 0x06004C2D RID: 19501 RVA: 0x000249CB File Offset: 0x00022BCB
		public unsafe static float DISPATCH_VEHICLE_USE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000989 RID: 2441
		[ObfuscatedName("ScheduleOne.Law.LawManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CA48 RID: 51784 RVA: 0x0030EB88 File Offset: 0x0030CD88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr);
				LawManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9");
				LawManager.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9__2_0");
				LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672725);
				LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672726);
			}

			// Token: 0x0600CA49 RID: 51785 RVA: 0x0030EC04 File Offset: 0x0030CE04
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA4A RID: 51786 RVA: 0x0030EC40 File Offset: 0x0030CE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165255, XrefRangeEnd = 165261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__2_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA4B RID: 51787 RVA: 0x00062594 File Offset: 0x00060794
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F09 RID: 16137
			// (get) Token: 0x0600CA4C RID: 51788 RVA: 0x0030EC74 File Offset: 0x0030CE74
			// (set) Token: 0x0600CA4D RID: 51789 RVA: 0x0006259D File Offset: 0x0006079D
			public unsafe static LawManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0A RID: 16138
			// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x0030EC9C File Offset: 0x0030CE9C
			// (set) Token: 0x0600CA4F RID: 51791 RVA: 0x000625AF File Offset: 0x000607AF
			public unsafe static UnityAction __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088D8 RID: 35032
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040088D9 RID: 35033
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040088DA RID: 35034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088DB RID: 35035
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0;
		}
	}
}
