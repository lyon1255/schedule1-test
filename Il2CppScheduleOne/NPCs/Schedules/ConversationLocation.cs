using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002DD RID: 733
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x06003637 RID: 13879 RVA: 0x0011F148 File Offset: 0x0011D348
		// Note: this type is marked as 'beforefieldinit'.
		static ConversationLocation()
		{
			Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "ConversationLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr);
			ConversationLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "StandPoints");
			ConversationLocation.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "NPCs");
			ConversationLocation.NativeFieldInfoPtr_npcReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "npcReady");
			ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669468);
			ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669469);
			ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669470);
			ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669471);
			ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669472);
			ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669473);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x0011F22C File Offset: 0x0011D42C
		public unsafe bool NPCsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138711, XrefRangeEnd = 138732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0011F268 File Offset: 0x0011D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138732, XrefRangeEnd = 138756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0011F29C File Offset: 0x0011D49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138756, XrefRangeEnd = 138764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetStandPoint(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0011F2EC File Offset: 0x0011D4EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138777, RefRangeEnd = 138780, XrefRangeStart = 138764, XrefRangeEnd = 138777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPCReady(NPC npc, bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0011F33C File Offset: 0x0011D53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138780, XrefRangeEnd = 138806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetOtherNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0011F38C File Offset: 0x0011D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138806, XrefRangeEnd = 138821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConversationLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0001C6DB File Offset: 0x0001A8DB
		public ConversationLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0011F3C8 File Offset: 0x0011D5C8
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0011F3F8 File Offset: 0x0011D5F8
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x0001C703 File Offset: 0x0001A903
		public unsafe List<NPC> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0011F428 File Offset: 0x0011D628
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0001C722 File Offset: 0x0001A922
		public unsafe Dictionary<NPC, bool> npcReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeFieldInfoPtr_npcReady;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092C RID: 2348
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C6AC RID: 50860 RVA: 0x00303BB8 File Offset: 0x00301DB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr);
				ConversationLocation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9");
				ConversationLocation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9__3_0");
				ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669475);
				ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669476);
			}

			// Token: 0x0600C6AD RID: 50861 RVA: 0x00303C34 File Offset: 0x00301E34
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6AE RID: 50862 RVA: 0x00303C70 File Offset: 0x00301E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138706, XrefRangeEnd = 138707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NPCsReady_b__3_0(KeyValuePair<NPC, bool> npcReady)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcReady));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6AF RID: 50863 RVA: 0x00060B3A File Offset: 0x0005ED3A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE4 RID: 15844
			// (get) Token: 0x0600C6B0 RID: 50864 RVA: 0x00303CC4 File Offset: 0x00301EC4
			// (set) Token: 0x0600C6B1 RID: 50865 RVA: 0x00060B43 File Offset: 0x0005ED43
			public unsafe static ConversationLocation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE5 RID: 15845
			// (get) Token: 0x0600C6B2 RID: 50866 RVA: 0x00303CEC File Offset: 0x00301EEC
			// (set) Token: 0x0600C6B3 RID: 50867 RVA: 0x00060B55 File Offset: 0x0005ED55
			public unsafe static Func<KeyValuePair<NPC, bool>, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<NPC, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008678 RID: 34424
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008679 RID: 34425
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400867A RID: 34426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400867B RID: 34427
			private static readonly IntPtr NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0;
		}

		// Token: 0x0200092D RID: 2349
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6B4 RID: 50868 RVA: 0x00303D14 File Offset: 0x00301F14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr);
				ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, "npc");
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669477);
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669478);
			}

			// Token: 0x0600C6B5 RID: 50869 RVA: 0x00303D7C File Offset: 0x00301F7C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6B6 RID: 50870 RVA: 0x00303DB8 File Offset: 0x00301FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138707, XrefRangeEnd = 138711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOtherNPC_b__0(NPC otherNPC)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherNPC);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6B7 RID: 50871 RVA: 0x00060B67 File Offset: 0x0005ED67
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE6 RID: 15846
			// (get) Token: 0x0600C6B8 RID: 50872 RVA: 0x00303E08 File Offset: 0x00302008
			// (set) Token: 0x0600C6B9 RID: 50873 RVA: 0x00060B70 File Offset: 0x0005ED70
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400867C RID: 34428
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x0400867D RID: 34429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400867E RID: 34430
			private static readonly IntPtr NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0;
		}
	}
}
