using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000234 RID: 564
	public class QuestsLoader : Loader
	{
		// Token: 0x06002DF4 RID: 11764 RVA: 0x00102A28 File Offset: 0x00100C28
		// Note: this type is marked as 'beforefieldinit'.
		static QuestsLoader()
		{
			Il2CppClassPointerStore<QuestsLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "QuestsLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestsLoader>.NativeClassPtr);
			QuestsLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsLoader>.NativeClassPtr, 100668575);
			QuestsLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestsLoader>.NativeClassPtr, 100668576);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00102A80 File Offset: 0x00100C80
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestsLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestsLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestsLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00102ABC File Offset: 0x00100CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127876, XrefRangeEnd = 127978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestsLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000188AD File Offset: 0x00016AAD
		public QuestsLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
