using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051C RID: 1308
	public class TrashBag : TrashItem
	{
		// Token: 0x0600747E RID: 29822 RVA: 0x001FBA14 File Offset: 0x001F9C14
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag()
		{
			Il2CppClassPointerStore<TrashBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag>.NativeClassPtr);
			TrashBag.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, "<Content>k__BackingField");
			TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677936);
			TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677937);
			TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677938);
			TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677939);
			TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677940);
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x001FBABC File Offset: 0x001F9CBC
		// (set) Token: 0x06007480 RID: 29824 RVA: 0x001FBAFC File Offset: 0x001F9CFC
		public unsafe TrashContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43167, RefRangeEnd = 43168, XrefRangeStart = 43167, XrefRangeEnd = 43168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x001FBB40 File Offset: 0x001F9D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227563, RefRangeEnd = 227564, XrefRangeStart = 227561, XrefRangeEnd = 227563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x001FBB84 File Offset: 0x001F9D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227564, XrefRangeEnd = 227574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x001FBBD0 File Offset: 0x001F9DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227574, XrefRangeEnd = 227598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x00037537 File Offset: 0x00035737
		public TrashBag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06007485 RID: 29829 RVA: 0x001FBC0C File Offset: 0x001F9E0C
		// (set) Token: 0x06007486 RID: 29830 RVA: 0x00037540 File Offset: 0x00035740
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F89 RID: 20361
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x04004F8A RID: 20362
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x04004F8B RID: 20363
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0;

		// Token: 0x04004F8C RID: 20364
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0;

		// Token: 0x04004F8D RID: 20365
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0;

		// Token: 0x04004F8E RID: 20366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
