using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000610 RID: 1552
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		// Token: 0x06008944 RID: 35140 RVA: 0x00240F80 File Offset: 0x0023F180
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessorySelection()
		{
			Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessorySelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr);
			ACAccessorySelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680382);
			ACAccessorySelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680383);
			ACAccessorySelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680384);
			ACAccessorySelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680385);
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x00241000 File Offset: 0x0023F200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253131, XrefRangeEnd = 253134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x00241050 File Offset: 0x0023F250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253134, XrefRangeEnd = 253146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x0024108C File Offset: 0x0023F28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253146, XrefRangeEnd = 253167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x002410E4 File Offset: 0x0023F2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253167, XrefRangeEnd = 253170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessorySelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x000418D6 File Offset: 0x0003FAD6
		public ACAccessorySelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005D37 RID: 23863
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0;

		// Token: 0x04005D38 RID: 23864
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0;

		// Token: 0x04005D39 RID: 23865
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0;

		// Token: 0x04005D3A RID: 23866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACAccessorySelection+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600D65A RID: 54874 RVA: 0x003306E0 File Offset: 0x0032E8E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr);
				ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, 100680386);
				ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, 100680387);
			}

			// Token: 0x0600D65B RID: 54875 RVA: 0x00330748 File Offset: 0x0032E948
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D65C RID: 54876 RVA: 0x00330784 File Offset: 0x0032E984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssetPathIndex_b__0(Accessory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D65D RID: 54877 RVA: 0x0006853F File Offset: 0x0006673F
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426E RID: 17006
			// (get) Token: 0x0600D65E RID: 54878 RVA: 0x003307D4 File Offset: 0x0032E9D4
			// (set) Token: 0x0600D65F RID: 54879 RVA: 0x00068548 File Offset: 0x00066748
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009028 RID: 36904
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04009029 RID: 36905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400902A RID: 36906
			private static readonly IntPtr NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0;
		}
	}
}
