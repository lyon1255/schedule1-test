using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000243 RID: 579
	public class NPCLoader : Loader
	{
		// Token: 0x06002E34 RID: 11828 RVA: 0x001038E4 File Offset: 0x00101AE4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCLoader()
		{
			Il2CppClassPointerStore<NPCLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "NPCLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr);
			NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668626);
			NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668627);
			NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668628);
			NPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100668629);
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x00103964 File Offset: 0x00101B64
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128712, XrefRangeEnd = 128719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x001039A8 File Offset: 0x00101BA8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 128730, RefRangeEnd = 128748, XrefRangeStart = 128719, XrefRangeEnd = 128730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x001039E4 File Offset: 0x00101BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128748, XrefRangeEnd = 128877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00103A34 File Offset: 0x00101C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128889, RefRangeEnd = 128891, XrefRangeStart = 128877, XrefRangeEnd = 128889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryLoadInventory(string mainPath, NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00018934 File Offset: 0x00016B34
		public NPCLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0;

		// Token: 0x02000904 RID: 2308
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.NPCLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C591 RID: 50577 RVA: 0x00300BD8 File Offset: 0x002FEDD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr);
				NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668630);
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668631);
			}

			// Token: 0x0600C592 RID: 50578 RVA: 0x00300C40 File Offset: 0x002FEE40
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C593 RID: 50579 RVA: 0x00300C7C File Offset: 0x002FEE7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128710, XrefRangeEnd = 128712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C594 RID: 50580 RVA: 0x0006024C File Offset: 0x0005E44C
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D9E RID: 15774
			// (get) Token: 0x0600C595 RID: 50581 RVA: 0x00300CCC File Offset: 0x002FEECC
			// (set) Token: 0x0600C596 RID: 50582 RVA: 0x00060255 File Offset: 0x0005E455
			public unsafe NPCData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085DD RID: 34269
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085DE RID: 34270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085DF RID: 34271
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0;
		}
	}
}
