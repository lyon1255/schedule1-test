using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C8 RID: 712
	public class QualityItemLoader : ItemLoader
	{
		// Token: 0x0600323D RID: 12861 RVA: 0x0010FB18 File Offset: 0x0010DD18
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemLoader()
		{
			Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "QualityItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr);
			QualityItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr, 100668884);
			QualityItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr, 100668885);
			QualityItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr, 100668886);
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x0010FB84 File Offset: 0x0010DD84
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131519, XrefRangeEnd = 131526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0010FBC8 File Offset: 0x0010DDC8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 131241, RefRangeEnd = 131261, XrefRangeStart = 131241, XrefRangeEnd = 131261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0010FC04 File Offset: 0x0010DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131526, XrefRangeEnd = 131550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0001AE14 File Offset: 0x00019014
		public QualityItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_ItemInstance_String_0;
	}
}
