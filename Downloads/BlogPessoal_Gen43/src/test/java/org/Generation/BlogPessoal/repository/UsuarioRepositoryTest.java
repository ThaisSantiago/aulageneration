package org.Generation.BlogPessoal.repository;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

import java.util.List;
import java.util.Optional;


import org.Generation.BlogPessoal.model.Usuario;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestInstance;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.context.SpringBootTest.WebEnvironment;


@SpringBootTest(webEnvironment = WebEnvironment.RANDOM_PORT)
@TestInstance(TestInstance.Lifecycle.PER_CLASS)
public class UsuarioRepositoryTest {
	
	
	@Autowired /*Injeta automaticamente os objetos dependentes*/
	private UsuarioRepository usuarioRepository;
	
	@BeforeAll /*inicializa os objetos do tipo Usuario e insere no Banco de dados*/
	void start() {
		
		
		usuarioRepository.save(new Usuario(0L, "Arnaldo Carvalho", "arnaldo@gmail.com.br", "10102020", "foto"));
		
		usuarioRepository.save(new Usuario(0L, "Brenda Carvalho", "brenda@gmail.com.br", "10102020", "foto"));
		
		usuarioRepository.save(new Usuario(0L, "Caio Carvalho", "caio@gmail.com.br", "10102020", "foto"));
		
		usuarioRepository.save(new Usuario(0L, "Daiane Flores", "daiane@gmail.com.br", "10102020", "foto"));
	}
	
	@Test /*este método executará um teste*/
	@DisplayName("Retorna 1 usuario")
	public void deveRetornarUmUsuario() {
		
		Optional<Usuario> usuario = usuarioRepository.findByUsuario("arnaldo@gmail.com.br");
		assertTrue(usuario.get().getUsuario().equals("arnaldo@gmail.com.br"));
	}
	
	@Test /*este método executará um teste*/
	@DisplayName("Retorna 3 usuario")
	public void deveRetornarTresUsuario() {
		
		List<Usuario> listaDeUsuarios = usuarioRepository.findAllByNomeContainingIgnoreCase("Carvalho");
		assertEquals(3, listaDeUsuarios.size());
		assertTrue(listaDeUsuarios.get(0).getNome().equals("Arnaldo Carvalho"));
		assertTrue(listaDeUsuarios.get(1).getNome().equals("Brenda Carvalho"));
		assertTrue(listaDeUsuarios.get(2).getNome().equals("Caio Carvalho"));
	}




}
