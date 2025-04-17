using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000246 RID: 582
	public class BuildableItemLoader : Loader
	{
		// Token: 0x06002E44 RID: 11844 RVA: 0x00103D00 File Offset: 0x00101F00
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemLoader()
		{
			Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BuildableItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr);
			BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668645);
			BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668646);
			BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668647);
			BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668648);
			BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668649);
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00103D94 File Offset: 0x00101F94
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129109, XrefRangeEnd = 129116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00103DD8 File Offset: 0x00101FD8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 129127, RefRangeEnd = 129152, XrefRangeStart = 129116, XrefRangeEnd = 129127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00103E14 File Offset: 0x00102014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129152, XrefRangeEnd = 129179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00103E64 File Offset: 0x00102064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129179, XrefRangeEnd = 129182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData GetBuildableItemData(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00103EB4 File Offset: 0x001020B4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 129186, RefRangeEnd = 129204, XrefRangeStart = 129182, XrefRangeEnd = 129186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string mainPath) where T : BuildableItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x0001894F File Offset: 0x00016B4F
		public BuildableItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_T_String_0;

		// Token: 0x02000909 RID: 2313
		private sealed class MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>
		{
			// Token: 0x040085EE RID: 34286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0, Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
