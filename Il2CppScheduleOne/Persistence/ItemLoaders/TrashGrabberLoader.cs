using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C9 RID: 713
	public class TrashGrabberLoader : ItemLoader
	{
		// Token: 0x06003242 RID: 12866 RVA: 0x0010FC60 File Offset: 0x0010DE60
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberLoader()
		{
			Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "TrashGrabberLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr);
			TrashGrabberLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr, 100668887);
			TrashGrabberLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr, 100668888);
			TrashGrabberLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr, 100668889);
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x0010FCCC File Offset: 0x0010DECC
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131550, XrefRangeEnd = 131557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0010FD10 File Offset: 0x0010DF10
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 131241, RefRangeEnd = 131261, XrefRangeStart = 131241, XrefRangeEnd = 131261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0010FD4C File Offset: 0x0010DF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131557, XrefRangeEnd = 131576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0001AE1D File Offset: 0x0001901D
		public TrashGrabberLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0;
	}
}
