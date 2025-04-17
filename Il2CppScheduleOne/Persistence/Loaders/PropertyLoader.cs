using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000233 RID: 563
	public class PropertyLoader : Loader
	{
		// Token: 0x06002DF0 RID: 11760 RVA: 0x00102944 File Offset: 0x00100B44
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyLoader()
		{
			Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertyLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr);
			PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668571);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668572);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x0010299C File Offset: 0x00100B9C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x001029D8 File Offset: 0x00100BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127875, RefRangeEnd = 127876, XrefRangeStart = 127735, XrefRangeEnd = 127875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000188A4 File Offset: 0x00016AA4
		public PropertyLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020008F9 RID: 2297
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertyLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600C546 RID: 50502 RVA: 0x002FFF88 File Offset: 0x002FE188
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr);
				PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, "objectPriorities");
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668573);
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668574);
			}

			// Token: 0x0600C547 RID: 50503 RVA: 0x002FFFF0 File Offset: 0x002FE1F0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C548 RID: 50504 RVA: 0x0030002C File Offset: 0x002FE22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127731, XrefRangeEnd = 127735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Load_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C549 RID: 50505 RVA: 0x0005FFDA File Offset: 0x0005E1DA
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x0600C54A RID: 50506 RVA: 0x0030007C File Offset: 0x002FE27C
			// (set) Token: 0x0600C54B RID: 50507 RVA: 0x0005FFE3 File Offset: 0x0005E1E3
			public unsafe Dictionary<string, int> objectPriorities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085B9 RID: 34233
			private static readonly IntPtr NativeFieldInfoPtr_objectPriorities;

			// Token: 0x040085BA RID: 34234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085BB RID: 34235
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0;
		}
	}
}
