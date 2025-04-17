using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000490 RID: 1168
	public class Explosion : MonoBehaviour
	{
		// Token: 0x06006524 RID: 25892 RVA: 0x001C8C98 File Offset: 0x001C6E98
		// Note: this type is marked as 'beforefieldinit'.
		static Explosion()
		{
			Il2CppClassPointerStore<Explosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Explosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosion>.NativeClassPtr);
			Explosion.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "Sound");
			Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676102);
			Explosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676103);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x001C8D04 File Offset: 0x001C6F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205608, RefRangeEnd = 205609, XrefRangeStart = 205507, XrefRangeEnd = 205608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x001C8D50 File Offset: 0x001C6F50
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x0002FD45 File Offset: 0x0002DF45
		public Explosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06006528 RID: 25896 RVA: 0x001C8D8C File Offset: 0x001C6F8C
		// (set) Token: 0x06006529 RID: 25897 RVA: 0x0002FD4E File Offset: 0x0002DF4E
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004500 RID: 17664
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04004501 RID: 17665
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x04004502 RID: 17666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
