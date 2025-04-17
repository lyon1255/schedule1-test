using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000462 RID: 1122
	public class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x0600617C RID: 24956 RVA: 0x001BC934 File Offset: 0x001BAB34
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentSingleton()
		{
			Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PersistentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr);
			PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675690);
			PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675691);
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x001BC9C8 File Offset: 0x001BABC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 200870, RefRangeEnd = 200880, XrefRangeStart = 200862, XrefRangeEnd = 200870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x001BCA04 File Offset: 0x001BAC04
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 200881, RefRangeEnd = 200892, XrefRangeStart = 200880, XrefRangeEnd = 200881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x0002E12E File Offset: 0x0002C32E
		public PersistentSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
