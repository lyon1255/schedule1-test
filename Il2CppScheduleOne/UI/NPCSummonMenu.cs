using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064D RID: 1613
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		// Token: 0x06008F25 RID: 36645 RVA: 0x0025272C File Offset: 0x0025092C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSummonMenu()
		{
			Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NPCSummonMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr);
			NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			NPCSummonMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Canvas");
			NPCSummonMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Container");
			NPCSummonMenu.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "EntryContainer");
			NPCSummonMenu.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Entries");
			NPCSummonMenu.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "callback");
			NPCSummonMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681055);
			NPCSummonMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681056);
			NPCSummonMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681057);
			NPCSummonMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681058);
			NPCSummonMenu.NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681059);
			NPCSummonMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681060);
			NPCSummonMenu.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681061);
			NPCSummonMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681062);
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x00252874 File Offset: 0x00250A74
		// (set) Token: 0x06008F27 RID: 36647 RVA: 0x002528B0 File Offset: 0x00250AB0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x002528F0 File Offset: 0x00250AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259819, XrefRangeEnd = 259836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSummonMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0025292C File Offset: 0x00250B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259836, XrefRangeEnd = 259837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x00252970 File Offset: 0x00250B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259837, XrefRangeEnd = 259913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<NPC> npcs, Action<NPC> _callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x002529C4 File Offset: 0x00250BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259941, RefRangeEnd = 259944, XrefRangeStart = 259913, XrefRangeEnd = 259941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x002529F8 File Offset: 0x00250BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259944, XrefRangeEnd = 259946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x00252A3C File Offset: 0x00250C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259946, XrefRangeEnd = 259949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSummonMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x00044FB3 File Offset: 0x000431B3
		public NPCSummonMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x00252A78 File Offset: 0x00250C78
		// (set) Token: 0x06008F30 RID: 36656 RVA: 0x00044FBC File Offset: 0x000431BC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x06008F31 RID: 36657 RVA: 0x00252AA0 File Offset: 0x00250CA0
		// (set) Token: 0x06008F32 RID: 36658 RVA: 0x00044FD7 File Offset: 0x000431D7
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x06008F33 RID: 36659 RVA: 0x00252AD0 File Offset: 0x00250CD0
		// (set) Token: 0x06008F34 RID: 36660 RVA: 0x00044FF6 File Offset: 0x000431F6
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x06008F35 RID: 36661 RVA: 0x00252B00 File Offset: 0x00250D00
		// (set) Token: 0x06008F36 RID: 36662 RVA: 0x00045015 File Offset: 0x00043215
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06008F37 RID: 36663 RVA: 0x00252B30 File Offset: 0x00250D30
		// (set) Token: 0x06008F38 RID: 36664 RVA: 0x00045034 File Offset: 0x00043234
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06008F39 RID: 36665 RVA: 0x00252B60 File Offset: 0x00250D60
		// (set) Token: 0x06008F3A RID: 36666 RVA: 0x00045053 File Offset: 0x00043253
		public unsafe Action<NPC> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060D9 RID: 24793
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040060DA RID: 24794
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040060DB RID: 24795
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060DC RID: 24796
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040060DD RID: 24797
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040060DE RID: 24798
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040060DF RID: 24799
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040060E0 RID: 24800
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040060E1 RID: 24801
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040060E2 RID: 24802
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060E3 RID: 24803
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0;

		// Token: 0x040060E4 RID: 24804
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040060E5 RID: 24805
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x040060E6 RID: 24806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B32 RID: 2866
		[ObfuscatedName("ScheduleOne.UI.NPCSummonMenu+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D820 RID: 55328 RVA: 0x00335734 File Offset: 0x00333934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr);
				NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, "npc");
				NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, 100681063);
				NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, 100681064);
			}

			// Token: 0x0600D821 RID: 55329 RVA: 0x003357B0 File Offset: 0x003339B0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D822 RID: 55330 RVA: 0x003357EC File Offset: 0x003339EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259817, XrefRangeEnd = 259819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D823 RID: 55331 RVA: 0x00069410 File Offset: 0x00067610
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FF RID: 17151
			// (get) Token: 0x0600D824 RID: 55332 RVA: 0x00335820 File Offset: 0x00333A20
			// (set) Token: 0x0600D825 RID: 55333 RVA: 0x00069419 File Offset: 0x00067619
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004300 RID: 17152
			// (get) Token: 0x0600D826 RID: 55334 RVA: 0x00335850 File Offset: 0x00333A50
			// (set) Token: 0x0600D827 RID: 55335 RVA: 0x00069438 File Offset: 0x00067638
			public unsafe NPCSummonMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSummonMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009134 RID: 37172
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04009135 RID: 37173
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009136 RID: 37174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009137 RID: 37175
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
