using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000611 RID: 1553
	public class ACAvatarLayerSelection : ACSelection<AvatarLayer>
	{
		// Token: 0x0600894A RID: 35146 RVA: 0x00241120 File Offset: 0x0023F320
		// Note: this type is marked as 'beforefieldinit'.
		static ACAvatarLayerSelection()
		{
			Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAvatarLayerSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr);
			ACAvatarLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr, 100680388);
			ACAvatarLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr, 100680389);
			ACAvatarLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr, 100680390);
			ACAvatarLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr, 100680391);
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x002411A0 File Offset: 0x0023F3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253170, XrefRangeEnd = 253173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAvatarLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x002411F0 File Offset: 0x0023F3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253173, XrefRangeEnd = 253185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAvatarLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0024122C File Offset: 0x0023F42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253185, XrefRangeEnd = 253206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAvatarLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x00241284 File Offset: 0x0023F484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253206, XrefRangeEnd = 253209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAvatarLayerSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x000418DF File Offset: 0x0003FADF
		public ACAvatarLayerSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005D3B RID: 23867
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0;

		// Token: 0x04005D3C RID: 23868
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0;

		// Token: 0x04005D3D RID: 23869
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0;

		// Token: 0x04005D3E RID: 23870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B06 RID: 2822
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACAvatarLayerSelection+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600D660 RID: 54880 RVA: 0x003307FC File Offset: 0x0032E9FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACAvatarLayerSelection>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr);
				ACAvatarLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ACAvatarLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680392);
				ACAvatarLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_AvatarLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680393);
			}

			// Token: 0x0600D661 RID: 54881 RVA: 0x00330864 File Offset: 0x0032EA64
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerSelection.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D662 RID: 54882 RVA: 0x003308A0 File Offset: 0x0032EAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssetPathIndex_b__0(AvatarLayer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_AvatarLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D663 RID: 54883 RVA: 0x00068567 File Offset: 0x00066767
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426F RID: 17007
			// (get) Token: 0x0600D664 RID: 54884 RVA: 0x003308F0 File Offset: 0x0032EAF0
			// (set) Token: 0x0600D665 RID: 54885 RVA: 0x00068570 File Offset: 0x00066770
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAvatarLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAvatarLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400902B RID: 36907
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x0400902C RID: 36908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400902D RID: 36909
			private static readonly IntPtr NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_AvatarLayer_0;
		}
	}
}
