using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000613 RID: 1555
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
	{
		// Token: 0x06008956 RID: 35158 RVA: 0x002413C4 File Offset: 0x0023F5C4
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerSelection()
		{
			Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr);
			ACFaceLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680396);
			ACFaceLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680397);
			ACFaceLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680398);
			ACFaceLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680399);
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x00241444 File Offset: 0x0023F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253215, XrefRangeEnd = 253218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x00241494 File Offset: 0x0023F694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253218, XrefRangeEnd = 253230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x002414D0 File Offset: 0x0023F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253230, XrefRangeEnd = 253251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x00241528 File Offset: 0x0023F728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253251, XrefRangeEnd = 253254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x0004190C File Offset: 0x0003FB0C
		public ACFaceLayerSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005D42 RID: 23874
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0;

		// Token: 0x04005D43 RID: 23875
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0;

		// Token: 0x04005D44 RID: 23876
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0;

		// Token: 0x04005D45 RID: 23877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B07 RID: 2823
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACFaceLayerSelection+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600D666 RID: 54886 RVA: 0x00330918 File Offset: 0x0032EB18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr);
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680400);
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680401);
			}

			// Token: 0x0600D667 RID: 54887 RVA: 0x00330980 File Offset: 0x0032EB80
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D668 RID: 54888 RVA: 0x003309BC File Offset: 0x0032EBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssetPathIndex_b__0(FaceLayer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D669 RID: 54889 RVA: 0x0006858F File Offset: 0x0006678F
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004270 RID: 17008
			// (get) Token: 0x0600D66A RID: 54890 RVA: 0x00330A0C File Offset: 0x0032EC0C
			// (set) Token: 0x0600D66B RID: 54891 RVA: 0x00068598 File Offset: 0x00066798
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400902E RID: 36910
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x0400902F RID: 36911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009030 RID: 36912
			private static readonly IntPtr NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0;
		}
	}
}
