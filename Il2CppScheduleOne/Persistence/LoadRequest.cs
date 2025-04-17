using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021D RID: 541
	public class LoadRequest : Object
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x000FFBCC File Offset: 0x000FDDCC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadRequest()
		{
			Il2CppClassPointerStore<LoadRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr);
			LoadRequest.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Path");
			LoadRequest.NativeFieldInfoPtr_Loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Loader");
			LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "<IsDone>k__BackingField");
			LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668465);
			LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668466);
			LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668467);
			LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668468);
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000FFC88 File Offset: 0x000FDE88
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x000FFCC4 File Offset: 0x000FDEC4
		public unsafe bool IsDone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000FFD04 File Offset: 0x000FDF04
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 126379, RefRangeEnd = 126388, XrefRangeStart = 126359, XrefRangeEnd = 126379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadRequest(string filePath, Loader loader) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000FFD64 File Offset: 0x000FDF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126388, XrefRangeEnd = 126395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00018336 File Offset: 0x00016536
		public LoadRequest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000FFD98 File Offset: 0x000FDF98
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x0001833F File Offset: 0x0001653F
		public unsafe string Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000FFDC0 File Offset: 0x000FDFC0
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x0001835E File Offset: 0x0001655E
		public unsafe Loader Loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000FFDF0 File Offset: 0x000FDFF0
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x0001837D File Offset: 0x0001657D
		public unsafe bool _IsDone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField)) = value;
			}
		}

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr_Path;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeFieldInfoPtr_Loader;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeFieldInfoPtr__IsDone_k__BackingField;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
