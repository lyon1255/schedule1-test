using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000153 RID: 339
	[Serializable]
	public class PreBuiltBlendshape : Object
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x000C7008 File Offset: 0x000C5208
		// Note: this type is marked as 'beforefieldinit'.
		static PreBuiltBlendshape()
		{
			Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "PreBuiltBlendshape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr);
			PreBuiltBlendshape.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, "name");
			PreBuiltBlendshape.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, "weight");
			PreBuiltBlendshape.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, 100666234);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000C7074 File Offset: 0x000C5274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70198, RefRangeEnd = 70199, XrefRangeStart = 70198, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreBuiltBlendshape(string name, float weight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreBuiltBlendshape.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0000FB5E File Offset: 0x0000DD5E
		public PreBuiltBlendshape(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x000C70D0 File Offset: 0x000C52D0
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0000FB67 File Offset: 0x0000DD67
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x000C70F8 File Offset: 0x000C52F8
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000FB86 File Offset: 0x0000DD86
		public unsafe float weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
